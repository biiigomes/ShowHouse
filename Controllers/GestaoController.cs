using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvc_desafio_master.DTO;
using MVChallenge.Data;

namespace mvc_desafio_master.Controllers
{
    namespace mvc_desafio_master.Controllers
{
     public class GestaoController : Controller
    {
        private readonly ApplicationDbContext database;
        public GestaoController(ApplicationDbContext database){
            this.database = database;
        }
        public IActionResult Index(){ 
            return View();
        }

        public IActionResult CasaShows(){
            var casaShow = database.CasaShows.Where(c => c.Status == true).ToList();
            return View(casaShow);
        }

        public IActionResult NovaCasaShow(){
            return View();
        }

        public IActionResult EditarCasaShows(int id){
            var casaShow = database.CasaShows.First(c=> c.Id == id);
            CasaShowDTO casaShowView = new CasaShowDTO();
            casaShowView.Id = casaShow.Id;
            casaShowView.Nome = casaShow.Nome;
            casaShowView.Endereco = casaShow.Endereco;
            return View(casaShowView);

        }

        public IActionResult Eventos(){
           var evento = database.Eventos.Include(e => e.CasaShow).Include(e => e.Estilo).Where(e => e.Status == true).ToList();
           return View(evento);
        }

        public IActionResult NovoEvento(){            
            ViewBag.Estilo = database.Estilos.ToList();
            ViewBag.CasaShow = database.CasaShows.ToList();
            return View();
        }

        public IActionResult EditarEventos(int id){
            var evento = database.Eventos.Include(e => e.CasaShow).Include(e => e.Estilo).First(e => e.Id == id);
            EventoDTO eventoView = new EventoDTO();
            eventoView.Id = evento.Id;
            eventoView.evento = evento.evento;
            eventoView.Capacidade = evento.Capacidade;
            eventoView.Data = evento.Data;
            eventoView.ValorIngresso = evento.ValorIngresso;
            eventoView.EstiloID = evento.Estilo.Id;
            eventoView.CasaShowID = evento.CasaShow.Id;
            ViewBag.Estilo = database.Estilos.ToList();
            ViewBag.CasaShow = database.CasaShows.ToList();
            return View(eventoView);
        } 

        public IActionResult Home(){
            var home = database.Eventos.Include(e => e.CasaShow).Include(e => e.Estilo).Where(h => h.Status == true).ToList();
            return View(home);
        }

        public IActionResult ComprarEvento(){
            var comprar = database.Eventos.Include(e => e.CasaShow).Include(e => e.Estilo).Where(c => c.Status == true);
            return View(comprar);
        }

        public IActionResult Historico(){
            return View();
        }

        public IActionResult Login(){
            return View();
        }
    }
  }
}
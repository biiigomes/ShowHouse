using System.Linq;
using Microsoft.AspNetCore.Mvc;
using mvc_desafio_master.DTO;
using MVChallenge.Data;
using MVChallenge.Models;

namespace MVChallenge.Controllers
{
    public class EventosController : Controller
    {
        private readonly ApplicationDbContext database;
        public EventosController(ApplicationDbContext database){
            this.database = database;
        }

        [HttpPost]
        public IActionResult Salvar(EventoDTO eventoTemporario){
            if(ModelState.IsValid){
                Evento evento = new Evento();
                evento.evento = eventoTemporario.evento;
                evento.Capacidade = eventoTemporario.Capacidade;
                evento.Data = eventoTemporario.Data;
                evento.ValorIngresso = eventoTemporario.ValorIngresso;
                evento.Estilo = database.Estilos.First(e => e.Id == eventoTemporario.EstiloID);
                evento.CasaShow = database.CasaShows.First(e => e.Id == eventoTemporario.CasaShowID);
                evento.Status = true;
                database.Eventos.Add(evento);
                database.SaveChanges();
                return RedirectToAction("Eventos", "Gestao");
            }else{
                return View("../Gestao/Eventos");
            }
        }

        [HttpPost]
        public IActionResult Atualizar(EventoDTO eventoTemporario){
            if(ModelState.IsValid){
                var eventos = database.Eventos.First(e => e.Id == eventoTemporario.Id);
                eventos.evento = eventoTemporario.evento;
                eventos.Capacidade = eventoTemporario.Capacidade;
                eventos.Data = eventoTemporario.Data;
                eventos.ValorIngresso = eventoTemporario.ValorIngresso;
                eventos.Estilo = database.Estilos.First(estilo => estilo.Id == eventoTemporario.CasaShowID);
                eventos.CasaShow = database.CasaShows.First(casaShows => casaShows.Id == eventoTemporario.CasaShowID);               
                database.SaveChanges();
                return RedirectToAction("Eventos", "Gestao");
            }else{
                return View("../Gestao/Eventos");
            }
        }


        [HttpPost]
        public IActionResult Deletar(int id){
            if(id > 0){
                var evento = database.Eventos.First(e => e.Id == id);
                evento.Status = false;
                database.SaveChanges();
                
            } return RedirectToAction("Eventos", "Gestao");
        }
    }
} 
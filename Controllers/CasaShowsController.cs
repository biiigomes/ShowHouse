using System.Linq;
using Microsoft.AspNetCore.Mvc;
using mvc_desafio_master.DTO;
using MVChallenge.Data;
using MVChallenge.Models;

namespace MVChallenge.Controllers
{
    public class CasaShowsController : Controller
    {
        private readonly ApplicationDbContext database;
        public CasaShowsController(ApplicationDbContext database){
            this.database = database;
        }

        [HttpPost]
        public IActionResult Salvar(CasaShowDTO casaShowTemporaria){
            if(ModelState.IsValid){
                CasaShow casaShow = new CasaShow();
                casaShow.Nome = casaShowTemporaria.Nome;
                casaShow.Endereco = casaShowTemporaria.Endereco;
                casaShow.Status = true;
                database.CasaShows.Add(casaShow);
                database.SaveChanges();
                return RedirectToAction("CasaShows", "Gestao");
            }else{
                return View("../Gestao/CasaShows");
            }
        }

        [HttpPost]
        public IActionResult Atualizar(CasaShowDTO casaShowTemporaria){
            if(ModelState.IsValid){
                var casaShow = database.CasaShows.First(c => c.Id == casaShowTemporaria.Id);
                casaShow.Nome = casaShowTemporaria.Nome;
                casaShow.Endereco = casaShowTemporaria.Endereco;
                database.SaveChanges();
                return RedirectToAction("CasaShows", "Gestao");
            }else{
                return View("../Gestao/CasaShows");
            }
        }

        [HttpPost]
        public IActionResult Deletar(int id){
            if(id > 0){
                var casaShow = database.CasaShows.First(c => c.Id == id);
                casaShow.Status = false;
                database.SaveChanges();
                
            } return RedirectToAction("CasaShows", "Gestao");
        } 
    }
} 
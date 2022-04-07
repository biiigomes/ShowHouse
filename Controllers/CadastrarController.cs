using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc_desafio_master.DTO;
using mvc_desafio_master.Models;
using MVChallenge.Data;
using MVChallenge.Migrations;
using MySqlConnector;

namespace mvc_desafio_master.Controllers
{
    
    public class CadastrarController : Controller
    {
        private readonly ApplicationDbContext database;
        public CadastrarController(ApplicationDbContext database){
            this.database = database;
        }

        [HttpPost] 
        public IActionResult Salvar(LoginDTO loginTemporario)
        {
            if(ModelState.IsValid){
            Login login = new Login();
            login.Nome = loginTemporario.Nome;
            login.UserName = loginTemporario.UserName;
            login.Senha = loginTemporario.Senha;
            login.Status = true;
            database.Logins.Add(login);
            database.SaveChanges();
            return RedirectToAction("Login", "Login");
            }else{
                return View("../Login/Login");
            }
        }
    }
}
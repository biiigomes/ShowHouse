using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;

namespace mvc_desafio_master.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return Json(new { Msg = "Usuário Já logado!" });
            }
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Logar(string UserName, string Senha, string Nome)
        {
            MySqlConnection mySqlConnection = new MySqlConnection("server=localhost;port=3306;database=challenge;uid=root;password=rout");
            await mySqlConnection.OpenAsync();

            MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandText = $"SELECT * FROM logins WHERE username = '{UserName}' AND senha = '{Senha}'";

            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            if(await reader.ReadAsync())
            {
                int usuarioId = reader.GetInt32(0);
                string nome = reader.GetString(1);

                List<Claim> direitosAcesso = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, usuarioId.ToString()),
                    new Claim(ClaimTypes.Name, nome)
                };

                var identity = new ClaimsIdentity(direitosAcesso, "Identity.Login");
                var userPrincipal = new ClaimsPrincipal(new[] {identity});

                await HttpContext.SignInAsync(userPrincipal,
                new AuthenticationProperties
                {
                   IsPersistent = false,
                   ExpiresUtc = DateTime.Now.AddHours(1)
                });

                return RedirectToAction("Home", "Gestao");
            }

        return Json(new{Msg="Acesso Negado"});

        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                await HttpContext.SignOutAsync();
            }
            return RedirectToAction("Login", "Login");
        }

        [HttpPost] 
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
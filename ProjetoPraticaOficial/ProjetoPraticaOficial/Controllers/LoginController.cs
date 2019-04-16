using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoPraticaOficial.DAO;
using ProjetoPraticaOficial.Models;

namespace ProjetoPraticaOficial.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string n, string e, string cpf, string s, string s2, string cel)
        {
            ClienteDAO dao = new ClienteDAO();
            dao.Adiciona(new Cliente(1, n, e,cpf,s,cel));
            //redirecionar para a camada de visualização
            return View();
        }
    }
}
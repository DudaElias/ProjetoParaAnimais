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
        public ActionResult CadastroCli(Cliente c)
        {
            ClienteDAO dao = new ClienteDAO();
            dao.Adiciona(c);
            //redirecionar para a camada de visualização
            return View();
        }

        [HttpPost]
        public ActionResult Login(Cliente c)
        {
            ClienteDAO dao = new ClienteDAO();
            Cliente retorno = dao.BuscaPorNome(c.Nome);
            if (retorno.Senha == c.Senha)
                return View();
            else
                return View();
        }
    }
}
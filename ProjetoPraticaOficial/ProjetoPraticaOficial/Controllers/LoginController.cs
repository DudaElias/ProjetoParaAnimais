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

        Cliente cli;
        Loja lo;
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
        public ActionResult CadastroEm(Loja e)
        {
            LojaDAO dao = new LojaDAO();
            dao.Adiciona(e);
            return View();
        }

        [HttpPost]
        public ActionResult LoginCli(Cliente c)
        {
            ClienteDAO dao = new ClienteDAO();
            cli = dao.BuscaPorNome(c.Nome);
            if (cli.Senha == c.Senha)
                return View();
            return null;
        }
        
        [HttpPost]
        public ActionResult LoginEm(Loja e)
        {
            LojaDAO dao = new LojaDAO();
            Loja lo = dao.BuscaPorNome(e.Nome);
            if (lo.CpfDono == e.CpfDono)
                return View();
            return null;
        }

        [HttpGet]

        public ActionResult EditarEm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditarDadosEm(Loja e)
        {
            LojaDAO dao = new LojaDAO();
            dao.Atualiza(e);
            return View();
        }

        public ActionResult Principal()
        {
            return View();
        }
        public ActionResult Pergunta()
        {
            return View();
        }

        public ActionResult Base()
        {
            return View();
        }
        public ActionResult SobreNos()
        {
            return View();
        }
        public ActionResult EditarDadosCli()
        {
            return View();
        }

        public ActionResult LoginCli()
        {
            return View();
        }

        public ActionResult Pedidos()
        {
            return View();
        }
    }
}
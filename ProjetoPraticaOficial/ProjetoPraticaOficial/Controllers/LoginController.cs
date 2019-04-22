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
            HttpCookie cookie = new HttpCookie("cli", cli.Nome);
            Response.Cookies.Add(cookie);
            if (cli.Senha == c.Senha)
                return View();
            return null;
        }
        
        [HttpPost]
        public ActionResult LoginEm(Loja e)
        {
            LojaDAO dao = new LojaDAO();
            lo = dao.BuscaPorNome(e.Nome);
            HttpCookie cookie = new HttpCookie("lo", lo.Id.ToString());
            cookie.Expires = DateTime.Now.AddHours(1);
            Request.Cookies.Add(cookie);
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

        public ActionResult EditarDadosEm()
        {
            return View();
        }

        public ActionResult AdicionarProduto()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdicionarProdutoVerdade(Produto p, string n)
        {

            FiltroDAO fDao = new FiltroDAO();
            ProdutoDAO dao = new ProdutoDAO();
            p.CodLoja = Convert.ToInt32(Request.Cookies.Get("lo"));
            if (fDao.BuscaPorNome(n) != null)
            {
                p.CodFiltro = fDao.BuscaPorNome(n).Id;
                dao.Adiciona(p);
            }
            return View();
        }
    }
}
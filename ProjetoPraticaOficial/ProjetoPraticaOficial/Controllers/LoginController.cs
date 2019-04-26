using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;
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
            HttpContext.Session.Add("cliente", cli);
            FiltroDAO daoF = new FiltroDAO();
            IList<Filtro> lista = daoF.Lista();
            ViewBag.Filtro = lista;
            if (cli.Senha == c.Senha)
                return View();
            return null;
        }
        
        [HttpPost]
        public ActionResult LoginEm(Loja e)
        {
            LojaDAO dao = new LojaDAO();
            lo = dao.BuscaPorNome(e.Nome);
            Session["loja"] = lo;
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

        public ActionResult CadastroLoja()
        {
            return View();
        }
        public ActionResult CriarLoginLoja()
        {
            return View();
        }
        public ActionResult CadastroCliente()
        {
            return View();
        }
        public ActionResult CriarLoginCliente()
        {
            return View();
        }
        public ActionResult LoginCli()
        {
            FiltroDAO dao = new FiltroDAO();
            IList<Filtro> lista = dao.Lista();
            ViewBag.Filtro = lista;
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
            p.CodLoja = ((Loja)Session["loja"]).Id;
            if (fDao.BuscaPorNome(n) == null)
            {
                Filtro f = new Filtro();
                f.Animal = n;
                fDao.Adiciona(f);
            }
            p.CodFiltro = fDao.BuscaPorNome(n).Id;
            dao.Adiciona(p);
            return RedirectToAction("AdicionarProduto", "Login");
        }

        public ActionResult FazerPesquisa(string pesquisa)
        {
            ProdutoDAO dao = new ProdutoDAO();
            Produto p = dao.BuscaPorNome(pesquisa);
            return View();
        }
    }
}
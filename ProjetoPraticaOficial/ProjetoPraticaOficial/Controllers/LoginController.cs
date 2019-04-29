﻿using System;
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
            Session["cli"] = cli;
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
            Session["lo"] = lo;
            if (lo.CpfDono == e.CpfDono)
                return View();
            return null;
        }

        public ActionResult LoginEm()
        {
            return View();
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
            if (e.Nome == "" || e.Nome ==  null)
                e.Nome = ((Loja)Session["lo"]).Nome;
            if (e.CpfDono == "" || e.CpfDono ==  null)
                e.CpfDono = ((Loja)Session["lo"]).CpfDono;
            if (e.Email == "" || e.Email ==  null)
                e.Email = ((Loja)Session["lo"]).Email;
            if (e.RgDono == "" || e.RgDono ==  null)
                e.RgDono = ((Loja)Session["lo"]).RgDono;
            if (e.OrgaoEmissor == "" || e.OrgaoEmissor == null)
                e.OrgaoEmissor = ((Loja)Session["lo"]).OrgaoEmissor;
            e.Id = ((Loja)Session["lo"]).Id;
            dao.Atualiza(e);

            return RedirectToAction("LoginEm", "Login");
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
        public ActionResult EditarDadosCliente(Cliente u)
        {

            ClienteDAO dao = new ClienteDAO();
            if (u.Nome == "" || u.Nome == null)
                u.Nome = ((Cliente)Session["cli"]).Nome;
            if(u.Cpf == "" || u.Cpf == null)
                u.Cpf = ((Cliente)Session["cli"]).Cpf;
            if(u.Email == "" || u.Email == null)
                u.Email = ((Cliente)Session["cli"]).Email;
            if(u.Senha == "" || u.Senha == null)
                u.Senha = ((Cliente)Session["cli"]).Senha;
            u.Telefone = ((Cliente)Session["cli"]).Telefone;
            u.Id = ((Cliente)Session["cli"]).Id;
            dao.Atualiza(u);

            return RedirectToAction("LoginCli", "Login");
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
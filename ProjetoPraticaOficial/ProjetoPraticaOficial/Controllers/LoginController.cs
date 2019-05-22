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
    using WebServiceCepCerto;
    using WebServiceCEP;
    public class LoginController : Controller
    {
        // GET: Login

        Cliente cli;
        Loja lo;
        [HttpGet]
        public JsonResult ComprarTeste(string cep)
        {
            string nCdEmpresa = string.Empty;
            string sDsSenha = string.Empty;
            string nCdServico = "41106";

            string sCepOrigem = "13043805";
            string sCepDestino = cep;
            int nCdFormato = 1;
            string nVlPeso = Convert.ToString(1);
            decimal nVlComprimento = 20;
            decimal nVlAltura = 20;
            decimal nVlLargura = 20;
            decimal nVlDiametro = 0;
            string sCdMaoPropria = "N";
            decimal nVlValorDeclarado = 0;
            string sCdAvisoRecebimento = "N";
            CalcPrecoPrazoWSSoapClient cliente = new CalcPrecoPrazoWSSoapClient();
            cResultado retornoCorreios = cliente.CalcPrecoPrazo(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento);
            Session["cep"] = cep;
            string[] result = new string[2];
            Session["correios"] = result;
            result[0] = retornoCorreios.Servicos[0].Valor;
            result[1] = retornoCorreios.Servicos[0].PrazoEntrega;
            return Json(result,JsonRequestBehavior.AllowGet);
        }
        
        public ActionResult EfetuarCompra(int numero, string complemento)
        {
            PedidoDAO dao = new PedidoDAO();
            ItemPedidoDAO daoI = new ItemPedidoDAO();
            ItemPedido item = new ItemPedido();
            item.CodProduto = ((Produto)Session["p"]).Id;
            item.Quantidade = numero;
            daoI.Adiciona(item);
            Pedido pedido = new Pedido();
            pedido.CodCliente = ((Cliente)Session["cli"]).Id;
            pedido.Endereco = Session["cep"].ToString()+ " " + complemento;
            pedido.DataPedido = DateTime.Today.Date;
            pedido.DataEntrega = DateTime.Today.Date.AddDays(Convert.ToDouble(((string[])Session["correios"])[1]));
            pedido.PrecoEntrega = Convert.ToDecimal(((string[])Session["correios"])[0]);
            pedido.CodPedido = item.Id;
            dao.Adiciona(pedido);
            return null;
        }
        public ActionResult ComprarDados(Produto p)
        {
            ViewBag.Produto = p;
            ViewBag.Cep = Session["end"];
            return View();
        }
        public ActionResult Cadastro()
        {
            return View();
        }


        [HttpPost]

        public ActionResult Filtrar(string filtro)
        {
            FiltroDAO dao = new FiltroDAO();
            Filtro fi = dao.BuscaPorNome(filtro);
            ProdutoDAO daoP = new ProdutoDAO();
            IList<Produto> lista = daoP.Lista();
            List<Produto> produtosEncontrados = new List<Produto>();
            foreach (var a in lista)
            {
                if (a.CodFiltro == fi.Id)
                    produtosEncontrados.Add(a);
            }
            List<Produto> p = produtosEncontrados;
            List<Filtro> f = new FiltroDAO().Lista().ToList();
            string pesquisa = null;
            var url = "Filtrar";
            return Json(new { redirectTo = Url.Action("FazerPesquisa", "Login", new { pesquisa, p, f })});
        }

        [HttpPost]
        public ActionResult CadastroCli(Cliente c)
        {
            ClienteDAO dao = new ClienteDAO();
            if (dao.BuscaPorNome(c.Nome) != null)
                return RedirectToAction("CadastroCliente", "Login");

            if (ModelState.IsValid)
            {
                dao.Adiciona(c);
                Session["cli"] = c;
                //redirecionar para a camada de visualização
                return LoginCli(c);
            }
            else
            {
                //colocar p ficar vermelho
                return View("CriarLoginCliente");
            }
        }
        [HttpPost]
        public ActionResult CadastroEm(Loja e)
        {

            LojaDAO dao = new LojaDAO();
            if (dao.BuscaPorNome(e.Nome) != null)
                return RedirectToAction("CadastroEmpresa", "Login");
            dao.Adiciona(e);
            Session["lo"] = e;
            //redirecionar para a camada de visualização
            return RedirectToAction("LoginEm", "Login", Session["lo"]);
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
            ProdutoDAO daoP = new ProdutoDAO();
            IList<Produto> p = daoP.Lista();
            ViewBag.Produto = p;
            if (cli != null && cli.Senha == c.Senha)
            {

                string pesquisa = null;
                string b = "2";
                return RedirectToAction("FazerPesquisa", "Login", new { pesquisa, b });
            }
            else
                return RedirectToAction("CriarLoginCliente");
        }
        
        [HttpPost]
        public ActionResult LoginEm(Loja e)
        {
            LojaDAO dao = new LojaDAO();
            lo = dao.BuscaPorNome(e.Nome);
            Session["lo"] = lo;
            if (lo != null && lo.CpfDono == e.CpfDono)
                return View();
            return RedirectToAction("CriarLoginLoja");
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
            Session["cli"] = null;
            Session["lo"] = null;
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
        //public ActionResult LoginCli()
        //{
        //    FiltroDAO dao = new FiltroDAO();
        //    IList<Filtro> lista = dao.Lista();
        //    ViewBag.Filtro = lista;

        //    ProdutoDAO daoP = new ProdutoDAO();
        //    IList<Produto> p = daoP.Lista();
        //    ViewBag.Produto = p;
        //    return View();
        //}

        public ActionResult Pedidos()
        {
            PedidoDAO dao = new PedidoDAO();
            ItemPedidoDAO dao2 = new ItemPedidoDAO();
            ProdutoDAO dao3 = new ProdutoDAO();
            List<int> po = new List<int>();
            List<Produto> produtos = new List<Produto>();
            List<Pedido> pedidos = dao.PedidosCliente(Convert.ToInt32(((Cliente)(Session["cli"])).Id), ref po);
            List<ItemPedido> itens = new List<ItemPedido>();
            foreach (var a in pedidos)
            {
                itens.Add(dao2.BuscaPorNome(a.CodPedido));
            }
            ViewBag.Pedido = pedidos;
            ViewBag.Produtos = produtos;
            ViewBag.Itens = itens;
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
            p.CodLoja = ((Loja)Session["lo"]).Id;
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

        public ActionResult FazerPesquisa(string pesquisa, string b) 
        {
            ProdutoDAO dao = new ProdutoDAO();
            FiltroDAO fDao = new FiltroDAO();

            List<Produto> produtosEncontrados = new List<Produto>();
            if (b == "1")
            {
                IList<Produto> f = dao.Lista();
                foreach (var a in f)
                {
                    if (a.CodFiltro == fDao.BuscaPorNome(pesquisa).Id)
                        produtosEncontrados.Add(a);
                }
            }
            else if (pesquisa == null || pesquisa.ToUpper() == "")
            {
                ViewBag.Produto = dao.Lista();
                ViewBag.Filtro = (new FiltroDAO().Lista());
                return View();

            }
            else
            {
                IList<Produto> lista = dao.Lista();
                foreach (var a in lista)
                {
                    string[] dados = a.Nome.Split(' ');
                    pesquisa = pesquisa.ToUpper();
                    bool pode = true;
                    string[] dados2 = a.Descricao.Split(' ');
                    foreach (var c in dados)
                        if (b.ToUpper() == pesquisa && pode != false)
                        {
                            produtosEncontrados.Add(a);
                            pode = false;
                        }
                    foreach (var c in dados2)
                        if (c.ToUpper() == pesquisa && pode != false)
                        {
                            produtosEncontrados.Add(a);
                            pode = false;
                        }
                }
            }
                ViewBag.Produto = produtosEncontrados;
                ViewBag.Filtro = (new FiltroDAO().Lista());
            return View();
        }
        [HttpPost]
        public ActionResult Comprar(Produto po)
        {
            ProdutoDAO dao = new ProdutoDAO();
            Produto x = dao.BuscaPorNome(po.Nome);
            ViewBag.Produto = x;
            Session["p"] = x;
            return View();
        }
        public ActionResult GraficoPareto()
        {
            return View();
        }


        public ActionResult PedidosARealizar()
        {
            PedidoDAO dao = new PedidoDAO();
            ItemPedidoDAO dao2 = new ItemPedidoDAO();
            ProdutoDAO dao3 = new ProdutoDAO();

            List<Pedido> pedidos = dao.Pedidos(Convert.ToInt32(((Loja)(Session["lo"])).Id));
            List<ItemPedido> itens = new List<ItemPedido>();
            List<Produto> produtos = new List<Produto>();
            foreach (var a in pedidos)
            {
                itens.Add(dao2.BuscaPorNome(a.CodPedido));
                produtos.Add(dao3.BuscaPorId(dao2.BuscaPorNome(a.CodPedido).CodProduto));
            }
            ViewBag.Pedido = pedidos;
            ViewBag.Produtos = produtos;
            ViewBag.Itens = itens;
            return View();
        }
    }
}
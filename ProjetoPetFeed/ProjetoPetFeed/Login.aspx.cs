using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLoja_Click(object sender, EventArgs e)
    {
        Label2.Text = "Sobre a Loja: ";
        btnLoja.Visible = false;
        btnCliente.Visible = false;
        txtEmailLoja.Text = "Qual o e-mail da loja?";
        txtEmailLoja.ForeColor = Color.Silver;
        txtEmailLoja.Visible = true;
        txtCelularLoja.Text = "Qual o celular da loja?";
        txtCelularLoja.ForeColor = Color.Silver;
        txtCelularLoja.Visible = true;
        txtNomeLoja.Text = "Qual o nome da loja?";
        txtNomeLoja.ForeColor = Color.Silver;
        txtNomeLoja.Visible = true;
        txtCPFLoja.Text = "Qual o CPF do dono da loja?";
        txtCPFLoja.ForeColor = Color.Silver;
        txtCPFLoja.Visible = true;
        txtRGLoja.Text = "Qual o RG do dono da loja?";
        txtRGLoja.ForeColor = Color.Silver;
        txtRGLoja.Visible = true;
        txtOrgaoLoja.Text = "Qual o órgão emissor da loja?";
        txtOrgaoLoja.ForeColor = Color.Silver;
        txtOrgaoLoja.Visible = true;
        btnCadastrarLoja.Visible = true;
    }

    protected void btnCliente_Click(object sender, EventArgs e)
    {
        Label2.Text = "Sobre o cliente: ";
        btnLoja.Visible = false;
        btnCliente.Visible = false;
        txtEmailCliente.Text = "Digite seu e-mail";
        txtEmailCliente.ForeColor = Color.Silver;
        txtEmailCliente.Visible = true;
        txtCelularCliente.Text = "Digite seu telefone";
        txtCelularCliente.ForeColor = Color.Silver;
        txtCelularCliente.Visible = true;
        txtNomeCliente.Text = "Digite seu nome";
        txtNomeCliente.ForeColor = Color.Silver;
        txtNomeCliente.Visible = true;
        txtSenhaCliente.Text = "Digite sua senha";
        txtSenhaCliente.ForeColor = Color.Silver;
        txtSenhaCliente.Visible = true;
        txtSenhaNovCliente.Text = "Confirme sua senha";
        txtSenhaNovCliente.ForeColor = Color.Silver;
        txtSenhaNovCliente.Visible = true;
        txtDDDCliente.Text = "DDD";
        txtDDDCliente.ForeColor = Color.Silver;
        txtDDDCliente.Visible = true;

        chkTermos.Visible = true;
        lblPreferencia.Text = "Entraremos em contato em caso de problemas (Dê preferência pelo cadastro do seu celular)";
        lblPreferencia.ForeColor = Color.Silver;
        lblPreferencia.Visible = true;

        lblTermos.Text = "Li e aceito os termos de uso e as políticas de privacidade";
        lblTermos.ForeColor = Color.LightGreen;
        lblTermos.Visible = true;

        btnCadastrarCliente.Visible = true;
    }
}
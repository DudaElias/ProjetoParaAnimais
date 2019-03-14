﻿using System;
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

    protected void btnEmpresa_Click(object sender, EventArgs e)
    {
        
        Label2.Text = "Sobre a Empresa: ";
        btnEmpresa.Visible = false;
        btnCliente.Visible = false;
        txtEmailEmpresa.Visible = true;
        txtCelularEmpresa.Visible = true;
        txtNomeEmpresa.Visible = true;
        txtCPFEmpresa.Visible = true;
        txtRGEmpresa.Visible = true;
        txtOrgaoEmpresa.Visible = true;
        btnCadastrarEmpresa.Visible = true;
    }

    protected void btnCliente_Click(object sender, EventArgs e)
    {
        Label2.Text = "Sobre o cliente: ";
        btnEmpresa.Visible = false;
        btnCliente.Visible = false;
        txtEmailCliente.Text = "Digite seu e-mail";
        txtEmailCliente.ForeColor = Color.Silver;
        txtEmailCliente.Visible = true;
        txtCelularCliente.Text = "Digite seu telefone";
        txtCelularCliente.ForeColor = Color.Silver;
        txtCelularCliente.Visible = true;
        txtCPFCliente.Text = "Digite seu CPF";
        txtCPFCliente.ForeColor = Color.Silver;
        txtCPFCliente.Visible = true;
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
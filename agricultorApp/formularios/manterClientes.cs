using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using agricultorApp.model;
using agricultorApp.dao;
using agricultorApp.util;
using agricultorApp.formularios.consultas;

namespace agricultorApp.formularios
{
    public partial class manterClientes : Form
    {
       
        public manterClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClienteModel cliente = new ClienteModel();
            cliente.Nome_razao = txtnome.Text;
            cliente.Status = true;
            cliente.Cpf_cnpj = txtcpfcnpj.Text;
            cliente.Telefone_fixo = mtbtel.Text;
            cliente.Telefone_cel = mtbcel.Text;
            cliente.Endereco = txtendereco.Text;
            cliente.Cidade = txtcidade.Text;
            cliente.Estado = txtuf.Text;

            ClienteDao clientebd = new ClienteDao();
            if (clientebd.InsertCliente(cliente) == 1)
            {
                MessageBox.Show("Cliente Cadastrado com sucesso.");
                LimpaCampos();
                ClienteDao clidao = new ClienteDao();
                txtcodigo.Text = clidao.RetriveClienteNextCodigo().ToString();
                
            }              


        }

        private void LimpaCampos()
        {
            txtnome.Text="";
            txtcpfcnpj.Text = "";
            mtbtel.Text ="" ;
            mtbcel.Text ="" ;
            txtendereco.Text ="" ;
            txtcidade.Text = "";
            txtuf.Text ="" ;
        }

        
        private void manterClientes_Load(object sender, EventArgs e)
        {
            ClienteDao clidao = new ClienteDao();
            txtcodigo.Text = clidao.RetriveClienteNextCodigo().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using agricultorApp.formularios.consultas;
using agricultorApp.dao;

namespace agricultorApp.formularios
{
    public partial class manterPrecos : Form
    {
        public manterPrecos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            consultaProdutos consulta = new consultaProdutos(this);
            consulta.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProdutoDao produtobd = new ProdutoDao();
            if (produtobd.InsertPrecos(Convert.ToInt32(txtproduto.Text), Convert.ToDouble(txtpreco.Text)) == 1)
            {
                MessageBox.Show("Preço Cadastrado com Sucesso!");
                txtproduto.Text = "";
                txtpreco.Text = "";
                txtprodutonome.Text = "";
            }
            else 
            {
                MessageBox.Show("Erro ao cadastrar preço.");  
             
            }
        }
    }
}

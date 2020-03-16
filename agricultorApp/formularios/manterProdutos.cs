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
using agricultorApp.formularios.consultas;

namespace agricultorApp.formularios
{
    public partial class manterProdutos : Form
    {
        public manterProdutos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProdutoModel produto = new ProdutoModel();
            produto.Nome = txtnome.Text;
            produto.Custo = 0;
            produto.Descricao = txtdescricao.Text;

            ProdutoDao produtobd = new ProdutoDao();
            if (produtobd.InsertProduto(produto) == 1)
            {
                MessageBox.Show("Produto Cadastrado com sucesso.");
                LimpaCampos();
                txtcodigo.Text = produtobd.RetriveProdutoNextCodigo().ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            this.Close();
            
        }

        private void LimpaCampos()
        {
            txtnome.Text = String.Empty;
            txtdescricao.Text = String.Empty;
        }

        private void manterProdutos_Load(object sender, EventArgs e)
        {
            ProdutoDao produtobd = new ProdutoDao();
            txtcodigo.Text = produtobd.RetriveProdutoNextCodigo().ToString();
        }
    }
}

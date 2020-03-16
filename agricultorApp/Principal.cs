using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using agricultorApp.formularios;
using agricultorApp.app_rel;



namespace agricultorApp
{
    public partial class Principal : Form
    {
        
        public Principal()
        {
            InitializeComponent();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about sobre = new about();            
            sobre.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manterClientes mclientes = new manterClientes();           
            mclientes.Show();

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manterProdutos mprodutos = new manterProdutos();
            mprodutos.Show();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manterPrecos mprecos = new manterPrecos();
            mprecos.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void cadastrarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manterPedidos mpedidos = new manterPedidos();
            mpedidos.Show();
        }

        private void fecharToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {


            relClientesForm rel = new relClientesForm();
            rel.Show();

            
           
            
        }       

       
    }
}

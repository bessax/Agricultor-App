using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace agricultorApp.formularios.consultas
{
    public partial class consultaClientes : Form
    {

        manterPedidos formc;
        int codigoselecionado;
        string descricao;

        public consultaClientes()
        {
            InitializeComponent();
        }

        public consultaClientes(manterPedidos formP)
        {
            InitializeComponent();
            formc = formP;
           
        }

        private void consultaClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agricultorDataSet.CLIENTES' table. You can move, or remove it, as needed.
            this.ClientesTableAdapter.Fill(this.agricultorDataSet.CLIENTES);

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
	        {
              DataRowView dr = (DataRowView)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
              codigoselecionado = Convert.ToInt32(dr["COD_CLIENTE"].ToString());
              descricao = dr["NOME_RAZAO"].ToString();               
	        } 
                        
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //Passando os dados entre formularios.
            formc.Txtcliente.Text = codigoselecionado.ToString();
            formc.Txtclientenome.Text = descricao;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

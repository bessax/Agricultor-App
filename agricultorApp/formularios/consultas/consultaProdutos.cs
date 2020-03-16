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
    public partial class consultaProdutos : Form
    {
        manterPedidos formc;
        manterPrecos formcp;
        int codigoselecionado;
        string descricao;

        public consultaProdutos()
        {
            InitializeComponent();
        }

        public consultaProdutos(manterPedidos formP)
        {
            InitializeComponent();
            formc = formP;
        }

        public consultaProdutos(manterPrecos formPr)
        {
            InitializeComponent();
            formcp = formPr;
        }

        private void consultaProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agricultorDataSet1.PRODUTOS' table. You can move, or remove it, as needed.
            this.pRODUTOSTableAdapter.Fill(this.agricultorDataSet1.PRODUTOS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //Passando os dados entre formularios.
            if (formc!=null)
            {
                formc.Txtproduto.Text = codigoselecionado.ToString();
                formc.Txtprodutonome.Text = descricao;  
            }
            if (formcp != null)
            {
                formcp.Txtproduto.Text = codigoselecionado.ToString();
                formcp.Txtprodutonome.Text = descricao;
            }
           
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataRowView dr = (DataRowView)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
                codigoselecionado = Convert.ToInt32(dr["COD_PRODUTO"].ToString());
                descricao = dr["NOME"].ToString();

            }
        }
    }
}

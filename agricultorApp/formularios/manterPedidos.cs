using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using agricultorApp.dao.conexao;
using agricultorApp.formularios.consultas;
using agricultorApp.model;
using agricultorApp.dao;

namespace agricultorApp.formularios
{
    public partial class manterPedidos : Form
    {
        double total_prod =0;
        double preco = 0;

        public manterPedidos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender; 
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            { //TODO - Button Clicked - Execute Code Here }
                if ((dataGridView1.Rows.Count>1))
                {
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);   
                }
                
            }
        }

        private void manterPedidos_Load(object sender, EventArgs e)
        {
            PedidosDao pedidobd = new PedidosDao();
            txtcodigo.Text = pedidobd.RetrivePedidoNextCodigo().ToString();
            dataGridView1.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consultaClientes consulta = new consultaClientes(this);
            consulta.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            if (txtquantidade.Text != "")
            {
                //adicionar linhar ao grid                
                ProdutoDao dao = new ProdutoDao();
                preco = dao.RetriveProdutoPreco(Convert.ToInt32(txtproduto.Text)) * Convert.ToDouble(txtquantidade.Text);
                this.dataGridView1.Rows.Add(txtproduto.Text, txtprodutonome.Text, txtquantidade.Text, preco);
                total_prod = total_prod + preco;
                txtTotal.Text = Convert.ToString(total_prod);
            }
            else 
            {
                MessageBox.Show("Favor informar quantidade do pedido.");
                txtquantidade.Focus();
            }
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PedidoModel pedido = new PedidoModel();
            pedido.Cod_cliente = Convert.ToInt32(txtcliente.Text);
            pedido.Data_pedido = dateTimePicker1.Value.Date;
            pedido.Endereco_entrega = txtendereco.Text;
            pedido.Cidade_entrega = txtcidade.Text;
            pedido.Estado_entrega = txtuf.Text;
           

            if (dataGridView1.Rows.Count>1)
            {
                
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    pedido.Itens.Add(new PedidoItemModel());
                    pedido.Itens[i].Cod_pedido = Convert.ToInt32(txtcodigo.Text);
                    pedido.Itens[i].Cod_produto = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    pedido.Itens[i].Quantidade = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);         

                }  
            }
            else
            {
                MessageBox.Show("Não há itens no Datagrid. Adicione um produto primeiro antes de continuar.");
            }

            PedidosDao pedidobd = new PedidosDao();
            if (pedidobd.InsertPedido(pedido) == 1)
            {
                MessageBox.Show("Pedido Cadastrado com sucesso.");
                LimpaCampos();                
                txtcodigo.Text = pedidobd.RetrivePedidoNextCodigo().ToString();
                dataGridView1.Rows.Clear();
                
            }           
        }

        private void LimpaCampos()
        {
            txtendereco.Text ="";
            txtcidade.Text="";
            txtuf.Text="";
            txtprodutonome.Text = "";
            txtquantidade.Text = "";
            txtTotal.Text = "";
            txtuf.Text = "";
            txtcliente.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            consultaProdutos consultap = new consultaProdutos(this);
            consultap.Show();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
             

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Configuration;
using agricultorApp.model;

namespace agricultorApp.dao.conexao
{
    class PedidosDao
    {
        int linhasafetadas;
        public int RetrivePedidoNextCodigo()
        {

            int nextCodigo;
            //Criando a conexão com o banco de dados.
            string strConexao = ConfigurationManager.ConnectionStrings["agricultorApp"].ToString().Trim();
            SqlCeConnection conn = new SqlCeConnection(strConexao);

            //Criação do objeto que receberá o retorno da consulta;
            SqlCeDataReader sdr;

            //Abrindo a conexão
            conn.Open();

            //Montando o comando SQL
            StringBuilder comando = new StringBuilder();
            comando.Append("SELECT COUNT(COD_PEDIDO) as nextcod FROM PEDIDOS ");

            //Montando o camando
            SqlCeCommand scComando = new SqlCeCommand(comando.ToString(), conn);


            //Executando o comando, quando o retorno do método é 1 significa que o comando foi executado
            // com sucesso.
            sdr = scComando.ExecuteReader();
            sdr.Read();

            nextCodigo = Convert.ToInt32(sdr["nextcod"].ToString());

            conn.Close();

            return nextCodigo + 1;
        }

        public int InsertPedido(PedidoModel pedido)
        {

            string strConexao = ConfigurationManager.ConnectionStrings["agricultorApp"].ToString().Trim();
            SqlCeConnection conn = new SqlCeConnection(strConexao);
            conn.Open();
            //Montando o comando SQL
            StringBuilder comando = new StringBuilder();
            comando.Append("INSERT INTO PEDIDOS (COD_CLIENTE,DATA_PEDIDO,ENDERECO_ENTREGA,CIDADE_ENTREGA,ESTADO_ENTREGA) ");
            comando.Append("VALUES ");
            comando.Append("(@COD_CLIENTE,@DATA_PEDIDO,@ENDERECO_ENTREGA,@CIDADE_ENTREGA,@ESTADO_ENTREGA)");
            //Montando o camando
            SqlCeCommand scComando = new SqlCeCommand(comando.ToString(), conn);
            scComando.Parameters.AddWithValue("@COD_CLIENTE", pedido.Cod_cliente);
            scComando.Parameters.AddWithValue("@DATA_PEDIDO", pedido.Data_pedido);
            scComando.Parameters.AddWithValue("@ENDERECO_ENTREGA", pedido.Endereco_entrega.ToUpper());
            scComando.Parameters.AddWithValue("@CIDADE_ENTREGA", pedido.Cidade_entrega.ToUpper());
            scComando.Parameters.AddWithValue("@ESTADO_ENTREGA", pedido.Estado_entrega.ToUpper());

            //Executando o comando, quando o retorno do método é 1 significa que o comando foi executado
            // com sucesso.
            linhasafetadas = scComando.ExecuteNonQuery();
            conn.Close();

            if (linhasafetadas==1)
            {
               InsertPedidoItem(pedido.Itens);
            }
            
            return linhasafetadas;
        }

        private int InsertPedidoItem(List<PedidoItemModel> list)
        {
            int totalitens;
            totalitens = list.Count -1;
            string strConexao = ConfigurationManager.ConnectionStrings["agricultorApp"].ToString().Trim();
            SqlCeConnection conn = new SqlCeConnection(strConexao);
            conn.Open();
            //Montando o comando SQL e executando
            StringBuilder comando = new StringBuilder();
            SqlCeCommand scComando =null;
            for (int i = 0; i < totalitens; i++)
			{
			    comando.Clear();
                comando.Append("INSERT INTO PEDIDO_PRODUTO(COD_PEDIDO,COD_PRODUTO,QUANTIDADE) ");
                comando.Append("VALUES ");
                comando.Append("(@COD_PEDIDO,@COD_PRODUTO,@QUANTIDADE)");
                //Montando o camando
                scComando = new SqlCeCommand(comando.ToString(), conn);
                scComando.Parameters.AddWithValue("@COD_PEDIDO", list[i].Cod_pedido);
                scComando.Parameters.AddWithValue("@COD_PRODUTO", list[i].Cod_produto);
                scComando.Parameters.AddWithValue("@QUANTIDADE", list[i].Quantidade);
                //Executando o comando, quando o retorno do método é 1 significa que o comando foi executado
                // com sucesso.
                linhasafetadas = scComando.ExecuteNonQuery();
			}
           
            conn.Close();
            return linhasafetadas;
        }


       
    }
}

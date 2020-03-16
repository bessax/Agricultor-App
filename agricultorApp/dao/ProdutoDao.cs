using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using agricultorApp.model;
using System.Configuration;

namespace agricultorApp.dao
{
    class ProdutoDao
    {
        int linhasafetadas;
        public int InsertProduto(ProdutoModel prod)
        {

            string strConexao = ConfigurationManager.ConnectionStrings["agricultorApp"].ToString().Trim();
            SqlCeConnection conn = new SqlCeConnection(strConexao);
            conn.Open();
            //Montando o comando SQL
            StringBuilder comando = new StringBuilder();
            comando.Append("INSERT INTO PRODUTOS(NOME,CUSTO,DESCRICAO) ");
            comando.Append("VALUES ");
            comando.Append("(@NOME,@CUSTO,@DESCRICAO)");
            //Montando o camando
            SqlCeCommand scComando = new SqlCeCommand(comando.ToString(), conn);
            scComando.Parameters.AddWithValue("@NOME", prod.Nome.ToUpper());
            scComando.Parameters.AddWithValue("@CUSTO", prod.Custo);
            scComando.Parameters.AddWithValue("@DESCRICAO", prod.Descricao.ToUpper());

            //Executando o comando, quando o retorno do método é 1 significa que o comando foi executado
            // com sucesso.
            linhasafetadas = scComando.ExecuteNonQuery();
            conn.Close();
            return linhasafetadas;
        }

        public int UpdateProduto(ProdutoModel prod)
        {

            string strConexao = ConfigurationManager.ConnectionStrings["agricultorApp"].ToString().Trim();
            SqlCeConnection conn = new SqlCeConnection(strConexao);
            conn.Open();
            //Montando o comando SQL
            StringBuilder comando = new StringBuilder();
            comando.Append("UPDATE PRODUTOS ");
            comando.Append("SET ");
            comando.Append("NOME=@NOME,CUSTO=@CUSTO,@DESCRICAO ");
            comando.Append("WHERE COD_PRODUTO = @CODIGO");
            //Montando o camando
            SqlCeCommand scComando = new SqlCeCommand(comando.ToString(), conn);
            scComando.Parameters.AddWithValue("@NOME", prod.Nome.ToUpper());
            scComando.Parameters.AddWithValue("@CUSTO",prod.Custo);
            scComando.Parameters.AddWithValue("@DESCRICAO",prod.Descricao.ToUpper());
            scComando.Parameters.AddWithValue("@CODIGO",prod.Cod_produto);
            //Executando o comando, quando o retorno do método é 1 significa que o comando foi executado
            // com sucesso.
            linhasafetadas = scComando.ExecuteNonQuery();
            conn.Close();
            return linhasafetadas;
        }
            

        public ProdutoModel RetriveProdutoModel(int codigo)
        {

            ProdutoModel prod = new ProdutoModel();
            //Criando a conexão com o banco de dados.
            string strConexao = ConfigurationManager.ConnectionStrings["agricultorApp"].ToString().Trim();
            SqlCeConnection conn = new SqlCeConnection(strConexao);

            //Criação do objeto que receberá o retorno da consulta;
            SqlCeDataReader sdr;

            //Abrindo a conexão
            conn.Open();

            //Montando o comando SQL
            StringBuilder comando = new StringBuilder();
            comando.Append("SELECT COD_PRODUTO,NOME,CUSTO,DESCRICAO FROM PRODUTOS ");
            //'?' curinga que representa um parametro que será recebido,
            comando.Append("WHERE COD_PRODUTO = " + codigo);

            //Montando o camando
            SqlCeCommand scComando = new SqlCeCommand(comando.ToString(), conn);


            //Executando o comando, quando o retorno do método é 1 significa que o comando foi executado
            // com sucesso.
            sdr = scComando.ExecuteReader();
            sdr.Read();

            prod.Cod_produto = Convert.ToInt32(sdr["COD_PRODUTO"].ToString());
            prod.Nome = sdr["NOME"].ToString();
            prod.Custo = Convert.ToDouble(sdr["CUSTO"].ToString());
            prod.Descricao = sdr["DESCRICAO"].ToString();      


            conn.Close();

            return prod;
        }

        public int RetriveProdutoNextCodigo()
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
            comando.Append("SELECT COUNT(COD_PRODUTO) as nextcod FROM PRODUTOS ");

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

        public List<ProdutoModel> RetriveAllProdutoModel(int codigo)
        {

            List<ProdutoModel> listprod = new List<ProdutoModel>();

            //Criando a conexão com o banco de dados.
            string strConexao = ConfigurationManager.ConnectionStrings["agricultorApp"].ToString().Trim();
            SqlCeConnection conn = new SqlCeConnection(strConexao);

            //Criação do objeto que receberá o retorno da consulta;
            SqlCeDataReader sdr;

            //Abrindo a conexão
            conn.Open();

            //Montando o comando SQL
            StringBuilder comando = new StringBuilder();
            comando.Append("SELECT * FROM PRODUTOS");

            //Montando o camando
            SqlCeCommand scComando = new SqlCeCommand(comando.ToString(), conn);


            //Executando o comando, quando o retorno do método é 1 significa que o comando foi executado
            // com sucesso.
            sdr = scComando.ExecuteReader();

            while (sdr.Read())
            {
                ProdutoModel prod = new ProdutoModel();
                prod.Cod_produto = Convert.ToInt32(sdr["COD_PRODUTO"].ToString());
                prod.Nome = sdr["NOME"].ToString();
                prod.Custo = Convert.ToDouble(sdr["CUSTO"].ToString());
                prod.Descricao = sdr["DESCRICAO"].ToString();

                listprod.Add(prod);
            }



            conn.Close();

            return listprod;
        }


        public double RetriveProdutoPreco(int Codigo)
        {

            double preco;
            //Criando a conexão com o banco de dados.
            string strConexao = ConfigurationManager.ConnectionStrings["agricultorApp"].ToString().Trim();
            SqlCeConnection conn = new SqlCeConnection(strConexao);

            //Criação do objeto que receberá o retorno da consulta;
            SqlCeDataReader sdr;

            //Abrindo a conexão
            conn.Open();

            //Montando o comando SQL
            StringBuilder comando = new StringBuilder();
            comando.Append("SELECT PRECO FROM PRECOS WHERE CODIGO=@CODIGO ");

            //Montando o camando
            SqlCeCommand scComando = new SqlCeCommand(comando.ToString(), conn);

            scComando.Parameters.AddWithValue("@CODIGO", Codigo);


            //Executando o comando, quando o retorno do método é 1 significa que o comando foi executado
            // com sucesso.
            sdr = scComando.ExecuteReader();
            sdr.Read();

            preco = Convert.ToDouble(sdr["preco"].ToString());

            conn.Close();

            return preco;
        }


        public int InsertPrecos(int codigo,double preco)
        {

            string strConexao = ConfigurationManager.ConnectionStrings["agricultorApp"].ToString().Trim();
            SqlCeConnection conn = new SqlCeConnection(strConexao);
            conn.Open();
            //Montando o comando SQL
            StringBuilder comando = new StringBuilder();
            comando.Append("INSERT INTO PRECOS(COD_PRODUTO,PRECO) ");
            comando.Append("VALUES ");
            comando.Append("(@COD_PRODUTO,@PRECO)");
            //Montando o camando
            SqlCeCommand scComando = new SqlCeCommand(comando.ToString(), conn);
            scComando.Parameters.AddWithValue("@COD_PRODUTO", codigo);
            scComando.Parameters.AddWithValue("@PRECO", preco);           

            //Executando o comando, quando o retorno do método é 1 significa que o comando foi executado
            // com sucesso.
            linhasafetadas = scComando.ExecuteNonQuery();
            conn.Close();
            return linhasafetadas;
        }

    }
}

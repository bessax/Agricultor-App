using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using agricultorApp.model;
using agricultorApp.dao.conexao;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SqlServerCe;

namespace agricultorApp.dao
{
    class ClienteDao
    {
        int linhasafetadas;
        public int InsertCliente(ClienteModel cli)
        {

            string strConexao = ConfigurationManager.ConnectionStrings["agricultorApp"].ToString().Trim();
            SqlCeConnection conn = new SqlCeConnection(strConexao);
            conn.Open();
            //Montando o comando SQL
            StringBuilder comando = new StringBuilder();
            comando.Append("INSERT INTO CLIENTES(NOME_RAZAO,STATUS,CPF_CNPJ,TELEFONE_FIXO,TELEFONE_CEL,ENDERECO,CIDADE,ESTADO) ");
            comando.Append("VALUES ");
            comando.Append("(@NOME_RAZAO,@STATUS,@CPF_CNPJ,@TELEFONE_FIXO,@TELEFONE_CEL,@ENDERECO,@CIDADE,@ESTADO)");            
            //Montando o camando
            SqlCeCommand scComando = new SqlCeCommand(comando.ToString(), conn);
            scComando.Parameters.AddWithValue("@NOME_RAZAO", cli.Nome_razao.ToUpper());
            scComando.Parameters.AddWithValue("@STATUS", cli.Status);
            scComando.Parameters.AddWithValue("@CPF_CNPJ", cli.Cpf_cnpj.ToUpper());
            scComando.Parameters.AddWithValue("@TELEFONE_FIXO", cli.Telefone_fixo);
            scComando.Parameters.AddWithValue("@TELEFONE_CEL", cli.Telefone_cel);
            scComando.Parameters.AddWithValue("@ENDERECO", cli.Endereco.ToUpper());
            scComando.Parameters.AddWithValue("@CIDADE", cli.Cidade.ToUpper());
            scComando.Parameters.AddWithValue("@ESTADO", cli.Estado.ToUpper());
            //Executando o comando, quando o retorno do método é 1 significa que o comando foi executado
            // com sucesso.
            linhasafetadas = scComando.ExecuteNonQuery();
            conn.Close();
            return linhasafetadas;
        }

        public int UpdateCliente(ClienteModel cli)
        {

            string strConexao = ConfigurationManager.ConnectionStrings["agricultorApp"].ToString().Trim();
            SqlCeConnection conn = new SqlCeConnection(strConexao);
            conn.Open();
            //Montando o comando SQL
            StringBuilder comando = new StringBuilder();
            comando.Append("UPDATE CLIENTES ");
            comando.Append("SET ");
            comando.Append("NOME_RAZAO=@NOME_RAZAO,STATUS=@STATUS,CPF_CNPJ=@CPF_CNPJ,TELEFONE_FIXO=@TELEFONE_FIXO,TELEFONE_CEL=@TELEFONE_CEL,ENDERECO=@ENDERECO,CIDADE=@CIDADE,ESTADO=@ESTADO ");
            comando.Append("WHERE COD_CLIENTE = @CODIGO");
            //Montando o camando
            SqlCeCommand scComando = new SqlCeCommand(comando.ToString(), conn);
            scComando.Parameters.AddWithValue("@NOME_RAZAO", cli.Nome_razao.ToUpper());
            scComando.Parameters.AddWithValue("@STATUS", cli.Status);
            scComando.Parameters.AddWithValue("@CPF_CNPJ", cli.Cpf_cnpj.ToUpper());
            scComando.Parameters.AddWithValue("@TELEFONE_FIXO", cli.Telefone_fixo);
            scComando.Parameters.AddWithValue("@TELEFONE_CEL", cli.Telefone_cel);
            scComando.Parameters.AddWithValue("@ENDERECO", cli.Endereco.ToUpper());
            scComando.Parameters.AddWithValue("@CIDADE", cli.Cidade.ToUpper());
            scComando.Parameters.AddWithValue("@ESTADO", cli.Estado.ToUpper());
            scComando.Parameters.AddWithValue("@CODIGO", cli.Cod_cliente);
            //Executando o comando, quando o retorno do método é 1 significa que o comando foi executado
            // com sucesso.
            linhasafetadas = scComando.ExecuteNonQuery();
            conn.Close();
            return linhasafetadas;
        }

        public int InativaCliente(ClienteModel cli)
        {

            string strConexao = ConfigurationManager.ConnectionStrings["agricultorApp"].ToString().Trim();
            SqlCeConnection conn = new SqlCeConnection(strConexao);
            conn.Open();
            //Montando o comando SQL
            StringBuilder comando = new StringBuilder();
            comando.Append("UPDATE CLIENTES ");
            comando.Append("SET ");
            comando.Append("sTATUS=@STATUS");
            comando.Append("WHERE COD_CLIENTE = @CODIGO");
            //Montando o camando
            SqlCeCommand scComando = new SqlCeCommand(comando.ToString(), conn);          
            scComando.Parameters.AddWithValue("@STATUS",false);
            scComando.Parameters.AddWithValue("@CODIGO", cli.Cod_cliente);
            //Executando o comando, quando o retorno do método é 1 significa que o comando foi executado
            // com sucesso.
            linhasafetadas = scComando.ExecuteNonQuery();
            conn.Close();
            return linhasafetadas;
        }

        public ClienteModel RetriveClienteModel(int codigo)
        {
            
            ClienteModel cli = new ClienteModel();
            //Criando a conexão com o banco de dados.
            string strConexao = ConfigurationManager.ConnectionStrings["agricultorApp"].ToString().Trim();
            SqlCeConnection conn = new SqlCeConnection(strConexao);

            //Criação do objeto que receberá o retorno da consulta;
            SqlCeDataReader sdr;

            //Abrindo a conexão
            conn.Open();

            //Montando o comando SQL
            StringBuilder comando = new StringBuilder();
            comando.Append("SELECT COD_CLIENTE,NOME_RAZAO,STATUS,CPF_CNPJ,TELEFONE_FIXO,TELEFONE_CEL,ENDERECO,CIDADE,ESTADO FROM CLIENTES ");
            //'?' curinga que representa um parametro que será recebido,
            comando.Append("WHERE COD_CLIENTE = " + codigo);

            //Montando o camando
            SqlCeCommand scComando = new SqlCeCommand(comando.ToString(), conn);        
            

            //Executando o comando, quando o retorno do método é 1 significa que o comando foi executado
            // com sucesso.
            sdr = scComando.ExecuteReader();
            sdr.Read();

            cli.Cod_cliente = Convert.ToInt32(sdr["COD_CLIENTE"].ToString());
            cli.Nome_razao = sdr["NOME_RAZAO"].ToString();
            cli.Status = Convert.ToBoolean(sdr["STATUS"].ToString());
            cli.Cpf_cnpj = sdr["CPF_CNPJ"].ToString();
            cli.Telefone_fixo = sdr["TELEFONE_FIXO"].ToString();
            cli.Telefone_cel = sdr["TELEFONE_CEL"].ToString();
            cli.Endereco = sdr["ENDERECO"].ToString();
            cli.Cidade = sdr["CIDADE"].ToString();
            cli.Estado = sdr["ESTADo"].ToString();      
          

            conn.Close();

            return cli;
        }

        public int RetriveClienteNextCodigo()
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
            comando.Append("SELECT COUNT(COD_CLIENTE) as nextcod FROM CLIENTES ");
           
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

        public List<ClienteModel> RetriveAllClienteModel(int codigo)
        {

            List<ClienteModel> listcli = new List<ClienteModel>();

            //Criando a conexão com o banco de dados.
            string strConexao = ConfigurationManager.ConnectionStrings["agricultorApp"].ToString().Trim();
            SqlCeConnection conn = new SqlCeConnection(strConexao);

            //Criação do objeto que receberá o retorno da consulta;
            SqlCeDataReader sdr;

            //Abrindo a conexão
            conn.Open();

            //Montando o comando SQL
            StringBuilder comando = new StringBuilder();
            comando.Append("SELECT * FROM CLIENTES");
           
            //Montando o camando
            SqlCeCommand scComando = new SqlCeCommand(comando.ToString(), conn);


            //Executando o comando, quando o retorno do método é 1 significa que o comando foi executado
            // com sucesso.
            sdr = scComando.ExecuteReader();
            
            while (sdr.Read())
            {
                ClienteModel cli = new ClienteModel();
                cli.Cod_cliente = Convert.ToInt32(sdr["COD_CLIENTE"].ToString());
                cli.Nome_razao = sdr["NOME_RAZAO"].ToString();
                cli.Status = Convert.ToBoolean(sdr["STATUS"].ToString());
                cli.Cpf_cnpj = sdr["CPF_CNPJ"].ToString();
                cli.Telefone_fixo = sdr["TELEFONE_FIXO"].ToString();
                cli.Telefone_cel = sdr["TELEFONE_CEL"].ToString();
                cli.Endereco = sdr["ENDERECO"].ToString();
                cli.Cidade = sdr["CIDADE"].ToString();
                cli.Estado = sdr["ESTADo"].ToString();

                listcli.Add(cli);
            }
            


            conn.Close();

            return listcli;
        }
    }
}

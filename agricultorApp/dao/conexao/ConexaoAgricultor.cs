using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace agricultorApp.dao.conexao
{
    class ConexaoAgricultor
    {

        private readonly string strConexao;        

        public SqlConnection getConexao()
        {
            return new SqlConnection(strConexao);
             
        } 

        public ConexaoAgricultor()
        {
            this.strConexao = ConfigurationManager.ConnectionStrings["agricultorApp"].ToString().Trim(); 
        }

     
    } 
}

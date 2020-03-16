using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agricultorApp.model
{
    class ClienteModel
    {
        int cod_cliente;

        public int Cod_cliente
        {
            get { return cod_cliente; }
            set { cod_cliente = value; }
        }

        string nome_razao;

        public string Nome_razao
        {
            get { return nome_razao; }
            set { nome_razao = value; }
        }

        bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        string cpf_cnpj;

        public string Cpf_cnpj
        {
            get { return cpf_cnpj; }
            set { cpf_cnpj = value; }
        }

        string telefone_fixo;

        public string Telefone_fixo
        {
            get { return telefone_fixo; }
            set { telefone_fixo = value; }
        }

        string telefone_cel;

        public string Telefone_cel
        {
            get { return telefone_cel; }
            set { telefone_cel = value; }
        }

        string endereco;

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        string cidade;

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}

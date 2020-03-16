using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agricultorApp.model
{
    class ProdutoModel
    {
        int cod_produto;
        public int Cod_produto
        {
            get { return cod_produto; }
            set { cod_produto = value; }
        }

        string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        double custo;
        public double Custo
        {
            get { return custo; }
            set { custo = value; }
        }

        string descricao;
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
    }
}

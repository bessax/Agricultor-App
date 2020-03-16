using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agricultorApp.model
{
    class PedidoItemModel
    {
        int cod_pedido;
        public int Cod_pedido
        {
            get { return cod_pedido; }
            set { cod_pedido = value; }
        }

        int cod_produto;
        public int Cod_produto
        {
            get { return cod_produto; }
            set { cod_produto = value; }
        }

        double quantidade;
        public double Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

    }
}

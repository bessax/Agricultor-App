using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace agricultorApp.model
{
    class PedidoModel
    {
        int cod_pedido;
        public int Cod_pedido
        {
            get { return cod_pedido; }
            set { cod_pedido = value; }
        }

        int cod_cliente;
        public int Cod_cliente
        {
            get { return cod_cliente; }
            set { cod_cliente = value; }
        }

        DateTime data_pedido;
        public DateTime Data_pedido
        {
            get { return data_pedido; }
            set { data_pedido = value; }
        }

        string endereco_entrega;
        public string Endereco_entrega
        {
            get { return endereco_entrega; }
            set { endereco_entrega = value; }
        }

        string cidade_entrega;
        public string Cidade_entrega
        {
            get { return cidade_entrega; }
            set { cidade_entrega = value; }
        }

        string estado_entrega;
        public string Estado_entrega
        {
            get { return estado_entrega; }
            set { estado_entrega = value; }
        }

        List<PedidoItemModel> itens = new List<PedidoItemModel>();

        public List<PedidoItemModel> Itens
        {
            get { return itens; }
            set { itens = value; }
        }
      


    }
}

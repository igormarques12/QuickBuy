using QuickBuy.Domínio.ObjetodeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domínio.Entidades
{
    class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }



        //um pedido pode ter vários itens
        public ICollection<ItemPedido> ItensPedidos { get; set; }
    }
}

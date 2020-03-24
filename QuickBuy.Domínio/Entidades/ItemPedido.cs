using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domínio.Entidades
{
    class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (ProdutoId == 0)
                MensagemValidacao.Add("Não foi identificado a referecia do produto");
            if (Quantidade == 0)
                MensagemValidacao.Add("Quantidade não foi informado");
        }
    }
}

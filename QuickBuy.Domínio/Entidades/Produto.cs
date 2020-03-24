using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domínio.Entidades
{
    class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                MensagemValidacao.Add("Insira o nome");
            if (string.IsNullOrEmpty(Descricao))
                MensagemValidacao.Add("Insira a descrição");
            if (Preco == 0)
                MensagemValidacao.Add("Nada é de graça bb");
        }
    }
}

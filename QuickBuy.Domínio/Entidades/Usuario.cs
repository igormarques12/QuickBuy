using System.Collections.Generic;

namespace QuickBuy.Domínio.Entidades
{
    class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        //um usuario pode pedir muitos pedidos
        public ICollection<Pedido>  Pedidos { get; set; }


    }
}

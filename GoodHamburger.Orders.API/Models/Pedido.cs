using GoodHamburger.Orders.API.Models.Enums;
using System.Collections.ObjectModel;

namespace GoodHamburger.Orders.API.Models;

public class Pedido
{
    public Pedido()
    {
        Itens = new Collection<ItemPedido>();
    }
    public int PedidoId { get; set; }
    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; } = null!;
    public Status Status { get; set; }
    public DateTime DataCriacao { get; set; }
    public decimal SubDesconto { get; set; }
    public decimal Desconto { get; set; }
    public decimal Total { get; set; }
    public ICollection<ItemPedido>? Itens { get; set; } 
}

namespace GoodHamburger.Orders.API.Models;

public class ItemPedido
{
    public int ItemPedidoId { get; set; }
    public int ProdutoId { get; set; }
    public Produto Produto { get; set; } = null!;
    public int PedidoId { get; set; }
    public Pedido Pedido { get; set; } = null!;
    public string? Nome { get; set; }
    public decimal Valor { get; set; }
    public int Quantidade { get; set; }
}

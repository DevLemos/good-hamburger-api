using GoodHamburger.Orders.API.Models.Enums;

namespace GoodHamburger.Orders.API.Models;
public class Produto
{
    public int ProdutoId { get; set; }
    public string? Nome { get; set; }
    public decimal Preco { get; set; }
    public TipoItem Tipo { get; set; }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoodHamburger.Orders.API.Models;

[Table("tbl_Pedido_Itens")]
public class ItemPedido
{
    [Key]
    [Column(name: "id_Pedido_Item")]
    public int ItemPedidoId { get; set; }

    [ForeignKey(nameof(ProdutoId))]
    [Column(name: "id_Produto")]
    public int ProdutoId { get; set; }
    public Produto Produto { get; set; } = null!;

    [ForeignKey(nameof(PedidoId))]
    [Column(name: "id_Pedido")]
    public int PedidoId { get; set; }
    public Pedido Pedido { get; set; } = null!;

    [Required]
    [StringLength(100)]
    [Column(name: "ds_Nome")]
    public string? Nome { get; set; }

    [Required]
    [Column(name: "vl_Preco", TypeName = "decimal(10,2)")]
    public decimal Preco { get; set; }

    [Required]
    [Column(name: "nr_Quantidade", TypeName = "int")]
    public int Quantidade { get; set; }
}

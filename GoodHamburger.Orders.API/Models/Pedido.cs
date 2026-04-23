using GoodHamburger.Orders.API.Models.Enums;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoodHamburger.Orders.API.Models;

[Table("tbl_Pedidos")]
public class Pedido
{
    public Pedido()
    {
        Itens = new Collection<ItemPedido>();
    }

    [Key]
    [Column(name: "id_Pedido")]
    public int PedidoId { get; set; }

    [ForeignKey(nameof(ClienteId))]
    [Column(name: "id_Cliente")]
    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; } = null!;

    [Required]
    [Column(name: "tp_Status", TypeName = "int")]
    public Status Status { get; set; }

    [Required]
    [Column(name: "dt_Criacao", TypeName = "datetime")]
    public DateTime DataCriacao { get; set; }

    [Required]
    [Column(name: "vl_SubTotal", TypeName = "decimal(10,2)")]
    public decimal SubTotal { get; set; }

    [Required]
    [Column(name: "vl_Desconto", TypeName = "decimal(10,2)")]
    public decimal Desconto { get; set; }

    [Required]
    [Column(name: "vl_Total", TypeName = "decimal(10,2)")]
    public decimal Total { get; set; }

    public ICollection<ItemPedido>? Itens { get; set; } 
}

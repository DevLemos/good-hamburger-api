using GoodHamburger.Orders.API.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoodHamburger.Orders.API.Models;

[Table("tbl_Produtos")]
public class Produto
{
    [Key]
    [Column(name: "id_Produto")]
    public int ProdutoId { get; set; }

    [Required]
    [StringLength(100)]
    [Column(name: "ds_Nome")]
    public string? Nome { get; set; }
    
    [Required]
    [Column(name: "vl_Preco", TypeName ="decimal(10,2)")]
    public decimal Preco { get; set; }

    [Required]
    [Column(name: "tp_Produto", TypeName = "int")]
    public TipoItem Tipo { get; set; }
}

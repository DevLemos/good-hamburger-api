using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoodHamburger.Orders.API.Models;

[Table("tbl_Clientes")]
public class Cliente
{
    [Key]
    [Column(name:"id_Cliente")]
    public int ClienteId { get; set; }

    [Required]
    [StringLength(80)]
    [Column(name: "ds_Nome")]
    public string? Nome { get; set; }

    [StringLength(20)]
    [Column(name: "nr_Telefone")]
    public string? Telefone { get; set; }
}

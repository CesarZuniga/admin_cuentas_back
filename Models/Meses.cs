using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.Cuentas.Models;

[Table("meses")]
public partial class Meses
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("descripcion", TypeName = "TEXT(20)")]
    public string? Descripcion { get; set; }
}

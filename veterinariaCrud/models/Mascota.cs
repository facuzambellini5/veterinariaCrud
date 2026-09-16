using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("mascotas")]
public class Mascota
{
    [Key]
    [Column("id_mascota")]
    public int IdMascota { get; set; }

    [Required]
    [Column("nombre")]
    [MaxLength(100)]
    public string Nombre { get; set; }

    [Required]
    [Column("especie")]
    [MaxLength(50)]
    public string Especie { get; set; }
    
    [Column("raza")]
    [MaxLength(50)]
    public string Raza { get; set; }

    [Required]
    [Column("num_dueno")]
    public int NumDueno { get; set; }

    [Required]
    [Column("nombre_dueno")]
    [MaxLength(50)]
    public string NombreDueno { get; set; }
}
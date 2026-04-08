using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreBackend.Domain.Entities;

[Table ("Product")] //Indica que estqa clase se mapea a la tabla product
public class Product
{
    [Key] //Le dice a Entity Framework que ProductId es la clave primaria
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProductId {get; private set;}

    [Required] //Indica que el campo es obligatorio
    public Guid ProductResourceId{get; set;}

    [Column("Name")]
    [StringLength(50)] //Limita la longitud maxima de Name a 50 caracteres, porque en SQL está [Name] NVARCHAR(50)
    public string ? Name {get;set;}
}
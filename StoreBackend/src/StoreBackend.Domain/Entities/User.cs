using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreBackend.Domain.Entities;

[Table("User")]
public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get; private set;}

    [Required]
    public int ExternalId {get; set;}

    [Required]
    [StringLength(50)]
    public String Username {get;set;}

    [Required]
    [StringLength(100)]
    public String Email{get; set;}

    [Required]
    [StringLength(256)]
    public String PasswordHash{get;set;}
}

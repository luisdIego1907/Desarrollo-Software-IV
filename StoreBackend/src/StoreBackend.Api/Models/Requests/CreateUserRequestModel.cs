using System;
using System.ComponentModel.DataAnnotations;

namespace StoreBackend.Api.Models.Requests;

public class CreateUserRequestModel
{

    [Required]
    [MaxLength(50)]
    public string? Username{get; set;}
}

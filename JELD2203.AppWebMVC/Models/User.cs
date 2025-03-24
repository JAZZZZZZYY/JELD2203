using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JELD2203.AppWebMVC.Models;

public partial class User
{
    public int UserId { get; set; }

    [Display(Name = "Usuario")]
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string Username { get; set; } = null!;

    [Required(ErrorMessage = "El Email es obligatorio.")]
    [EmailAddress(ErrorMessage = "El correo electrónico no tiene un formato válido.")]
    public string Email { get; set; } = null!;

    [Display(Name = "Contraseña")]
    [Required(ErrorMessage = "La contraseña es obligatorio.")]
    [DataType(DataType.Password)]
    [StringLength(40, MinimumLength = 5, ErrorMessage = "La contraseña debe tener entre 5 y 50 caracteres.")]
    public string PasswordHash { get; set; } = null!;

    [Display(Name = "Rol")]
    [Required(ErrorMessage = "El Rol es obligatorio.")]
    public string Role { get; set; } = null!;

    [NotMapped]
    [StringLength(40, MinimumLength = 5, ErrorMessage = "La contraseña debe tener entre 5 y 50 caracteres.")]
    [Display(Name = "Confirmar Contraseña")]
    [DataType(DataType.Password)]
    [Compare("PasswordHash", ErrorMessage = "Las contraseñas no coinciden.")]
    public string? ConfirmarPassword { get; set; } = null!;
}

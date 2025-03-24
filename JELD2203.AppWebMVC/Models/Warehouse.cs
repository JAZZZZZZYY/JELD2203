using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JELD2203.AppWebMVC.Models;

public partial class Warehouse
{
    public int WarehouseId { get; set; }

    [Display(Name = "Bodega")]
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string WarehouseName { get; set; } = null!;

    [Display(Name = "Nota")]
    [Required(ErrorMessage = "La nota es obligatorio.")]
    public string? Notes { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
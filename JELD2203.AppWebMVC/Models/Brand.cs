using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JELD2203.AppWebMVC.Models;

public partial class Brand
{
    public int BrandId { get; set; }

    [Display(Name = "Marca")]
    public string BrandName { get; set; } = null!;

    [Display(Name = "Pais")]
    public string? Country { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}


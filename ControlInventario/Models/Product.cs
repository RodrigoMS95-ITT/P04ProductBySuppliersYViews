using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlTypes;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ControlInventario.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name="Codigo")]        
        public string ProductCode { get; set; }
        [Display(Name = "Nombre")]
        public string ProductName { get; set; }
        [Display(Name = "Descripción")]
        public string Description { get; set; }
        [Display(Name = "Cantidad")]
        public int Quantity { get; set; }
        [Display(Name = "Precio")]
        public decimal Price { get; set; }
        public int SupplirId { get; set; }
        [ForeignKey("SupplirId")]
        public Supplier Supplier { get; set; }

    }
}
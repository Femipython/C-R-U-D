using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Crud_project.Models
{
    public class NewReceiptClass
    {
        [Key]

        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Item")]
        [Display (Name = "Item")]
        public string Item { get; set; }

        [Required(ErrorMessage = "Enter Quantity")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Enter Unit Price")]
        [Display(Name = "Unit Price")]
        [DataType(DataType.Currency)]
        public float UnitPrice { get; set; }

        [Required(ErrorMessage = "Enter Total Price")]
        [Display(Name = "Total Price")]
        [DataType(DataType.Currency)]
        public float TotalPrice { get; set; }
    }
}

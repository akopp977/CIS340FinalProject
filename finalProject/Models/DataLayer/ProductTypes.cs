using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace finalProject.Models.DataLayer
{
    [Table("Product_Types")]
    public partial class ProductTypes
    {
        public ProductTypes()
        {
            Products = new HashSet<Products>();
        }

        [Key]
        [Column("Type_ID")]
        public int TypeId { get; set; }
        [Required]
        [StringLength(30)]
        public string Type { get; set; }

        [InverseProperty("Type")]
        public virtual ICollection<Products> Products { get; set; }
    }
}

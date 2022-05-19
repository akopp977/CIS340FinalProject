using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace finalProject.Models.DataLayer
{
    public partial class Products
    {
        public Products()
        {
            TransactionItems = new HashSet<TransactionItems>();
        }

        [Key]
        [Column("Prod_ID")]
        public int ProdId { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [StringLength(300)]
        public string Desc { get; set; }
        [Column("Type_ID")]
        public int TypeId { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [ForeignKey(nameof(TypeId))]
        [InverseProperty(nameof(ProductTypes.Products))]
        public virtual ProductTypes Type { get; set; }
        [InverseProperty("Prod")]
        public virtual ICollection<TransactionItems> TransactionItems { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace finalProject.Models.DataLayer
{
    [Table("Transaction_Items")]
    public partial class TransactionItems
    {
        [Key]
        [Column("Tran_ID")]
        public int TranId { get; set; }
        [Key]
        [Column("Prod_ID")]
        public int ProdId { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        [ForeignKey(nameof(ProdId))]
        [InverseProperty(nameof(Products.TransactionItems))]
        public virtual Products Prod { get; set; }
        [ForeignKey(nameof(TranId))]
        [InverseProperty(nameof(Transactions.TransactionItems))]
        public virtual Transactions Tran { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace finalProject.Models.DataLayer
{
    public partial class Transactions
    {
        public Transactions()
        {
            TransactionItems = new HashSet<TransactionItems>();
        }

        [Key]
        [Column("Tran_ID")]
        public int TranId { get; set; }
        [Column(TypeName = "money")]
        public decimal Total { get; set; }
        [Column("Date_Time", TypeName = "datetime")]
        public DateTime DateTime { get; set; }
        [Column("Cus_ID")]
        public int CusId { get; set; }

        [ForeignKey(nameof(CusId))]
        [InverseProperty(nameof(Customers.Transactions))]
        public virtual Customers Cus { get; set; }
        [InverseProperty("Tran")]
        public virtual ICollection<TransactionItems> TransactionItems { get; set; }
    }
}

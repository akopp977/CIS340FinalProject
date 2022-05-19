using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace finalProject.Models.DataLayer
{
    [Table("Customer_Types")]
    public partial class CustomerTypes
    {
        public CustomerTypes()
        {
            Customers = new HashSet<Customers>();
        }

        [Key]
        [Column("Cus_Type_ID")]
        public int CusTypeId { get; set; }
        [Required]
        [Column("Customer_Type")]
        [StringLength(30)]
        public string CustomerType { get; set; }

        [InverseProperty("CusType")]
        public virtual ICollection<Customers> Customers { get; set; }
    }
}

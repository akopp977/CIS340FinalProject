using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace finalProject.Models.DataLayer
{
    public partial class Customers
    {
        public Customers()
        {
            Transactions = new HashSet<Transactions>();
        }

        [Required]
        [Column("First_Name")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [Column("Last_Name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [Column("Phone_Number")]
        [StringLength(15)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(20)]
        public string Username { get; set; }
        [Key]
        [Column("Cus_ID")]
        public int CusId { get; set; }
        [Column("Cus_Type_ID")]
        public int? CusTypeId { get; set; }

        [ForeignKey(nameof(CusTypeId))]
        [InverseProperty(nameof(CustomerTypes.Customers))]
        public virtual CustomerTypes CusType { get; set; }
        [InverseProperty("Cus")]
        public virtual ICollection<Transactions> Transactions { get; set; }
    }
}

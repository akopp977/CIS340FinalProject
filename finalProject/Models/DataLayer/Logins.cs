using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace finalProject.Models.DataLayer
{
    public partial class Logins
    {
        [Key]
        [Column("Username")]
        [Required]
        [StringLength(20)]
        public string Username { get; set; }
        [Required]
        [StringLength(20)]
        public string Password { get; set; }
        public bool Admin { get; set; }
        [Column("Cus_ID")]
        public int? CusId { get; set; }

        [ForeignKey(nameof(CusId))]
        public virtual Customers Cus { get; set; }
        public virtual Customers UsernameNavigation { get; set; }
    }
}

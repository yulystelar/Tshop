using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Model.Models
{
    [Table("Customer")]
    public class Customers
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]


        public int CustomerId { get; set; }
        [Required] public int ClientId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNotSign { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public int CustomerType { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string TaxCode { get; set; }
        public string BankAccount { get; set; }
        public string BankName { get; set; }
        public string ContactName { get; set; }
        public int PartnerId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public int TinhId { get; set; }
        public int QuanId { get; set; }

    }
}

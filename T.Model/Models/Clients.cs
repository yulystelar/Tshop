using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Model.Models
{
    [Table("Client")]
    public class Clients
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]


        public int ClientId { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Hotline { get; set; }
        public string Fax { get; set; }
        public string ConnectionString { get; set; }
        public string Domain { get; set; }
        public int Type { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime StartDate { get; set; }

    }
}

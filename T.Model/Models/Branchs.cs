using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Model.Models
{
    [Table("BanMay")]
    class Branchs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int BranchID { get; set; }

        public int ClientID { get; set; }
        public string BranchName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Hotline { get; set; }
        public int Main { get; set; }
        public DateTime CreatedDate { get; set; }
        
        public int CreatedBy { get; set; }
        public string Location { get; set; }
        public int QuanID { get; set; }

    }
}

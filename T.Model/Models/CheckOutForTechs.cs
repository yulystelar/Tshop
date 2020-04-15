using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Model.Models
{
    [Table("CheckOutForTech")]
    public class CheckOutForTechs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int CheckOutForTechID { get; set; }
    
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public int ClientID { get; set; }
        public int BranchID { get; set; }
        public int TechnicianID { get; set; }
        public int CheckOutNumber { get; set; }
        public string CheckOutCode { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string Description { get; set; }
        public int MaKy { get; set; }

    }
}

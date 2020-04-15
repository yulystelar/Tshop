using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Model.Models
{
    [Table("CheckOutLRForTech")]
    public class CheckOutLRForTechs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int CheckOutLRForTechId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public int ClientId { get; set; }
        public int BranchId { get; set; }
        public int TechnicianId { get; set; }
        public int CheckOutNumber { get; set; }
        public string CheckOutLRCode { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string Description { get; set; }
        public int MaKy { get; set; }
    }
}

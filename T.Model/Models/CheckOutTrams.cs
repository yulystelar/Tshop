using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Model.Models
{
    [Table("CapLinhKienTram")]
    public class CapLinhKienTrams
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]


        public int CapLinhKienTramId { get; set; }
        public int BranchId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int CustomerId { get; set; }
        public DateTime NgayCap { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public int MaKy { get; set; }
        public int CheckOutNumber { get; set; }
        public string CheckOutCode { get; set; }
        public string Description { get; set; }

    }
}

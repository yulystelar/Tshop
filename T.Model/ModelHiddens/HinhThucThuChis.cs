using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Model.Models
{
    [Table("MaHinhThucThuChi")]
    public class MaHinhThucThuChis
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]


        public int MaHinhThucThuChi { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string TenHinhThucThuChi { get; set; }
        public string IsPublic { get; set; }
        public string Code { get; set; }

    }
}

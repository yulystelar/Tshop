using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Model.Models
{
    [Table("ChamCong")]
    public class ChamCongs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ChamCong { get; set; }

        public int NhanVienID { get; set; }
        public int SoNgayNghi { get; set; }
        public int SoNgayTre { get; set; }
        public int LoaiTruLuong { get; set; }
        public int LoaiNghi { get; set; }
        public DateTime NgayCham { get; set; }
        public string SoPhieu { get; set; }
        public int TangCa { get; set; }
        public int VeSom { get; set; }
        public DateTime CreatedDay { get; set; }

    }
}

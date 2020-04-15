using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Model.Models
{
    [Table("HoaDonDetail")]
    public class HoaDonDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int HoaDonDetailId { get; set; }
        public int HoaDonId { get; set; }
        public string NoiDung { get; set; }
        public string Dvt { get; set; }
        public int SoLuong { get; set; }
        public string DonGia { get; set; }
        public string ThanhTien { get; set; }
        public int MaPhieu { get; set; }
        public int LoaiPhieu { get; set; }

    }
}

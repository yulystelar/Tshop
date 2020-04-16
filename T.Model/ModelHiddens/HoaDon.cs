using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Model.Models
{
    [Table("HoaDon")]
    public class HoaDons
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]



        public int HoaDonId { get; set; }
        public int CustomerId { get; set; }
        public DateTime NgayXuat { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string TongTien { get; set; }
        public string VAT { get; set; }
        public string TienThue { get; set; }
        [Required] public string TongThanhToan { get; set; }
        public string HoTen { get; set; }
        public int BranchId { get; set; }
        public string SoHoaDon { get; set; }
        public int HinhThucId { get; set; }
        public string NoiDung { get; set; }
        public string NotMST { get; set; }
        public int LoaiHD { get; set; }

    }
}

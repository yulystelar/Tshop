
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace T.Model.Models
{
    [Table("BangLuong")]
    public class BangLuongs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BangLuongID { get; set; }
        public int NhanVienID { set; get; }
        public int ChamCongID { set; get; }
        [Required]
        public int LuongCung { set; get; }
        [Required]
        public int PhuCap { set; get; }
        [Required]
        public int TruChamCong { set; get; }
        [Required]
        public int ViPham { set; get; }
        [Required]
        public int TongTien { set; get; }
        
        public string GhiChu { set; get; }
        [Required]
        public int CongSuaChua { set; get; }
        [Required]
        public int CongBaoHanh { set; get; }

        public int MaKy { set; get; }
        public int BaoHiem { set; get; }
        public int TongPhat { set; get; }
        public int TongThuong { set; get; }
        public int TienNgayCong { set; get; }
        public int TienGioCong { set; get; }
        public int TienTangCa { set; get; }
        public int TienUngLuong { set; get; }
        public int TienNghi { set; get; }
        public int TienDiTre { set; get; }
        public int TienVeSom { set; get; }
        public int TongLuong { set; get; }
        public int AnChia { set; get; }

    }
}

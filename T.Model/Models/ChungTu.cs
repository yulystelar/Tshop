using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Model.Models
{
    [Table("ChungTu")]
    public class ChungTus
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]


        public int ChungTuId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int ClientId { get; set; }
        public int BranchId { get; set; }
        public int CustomerId { get; set; }
        public int MaKy { get; set; }
        public int MaHinhThucThuChi { get; set; }
        public int MaLoaiThuChi { get; set; }
        public int MaTienTe { get; set; }
        public DateTime NgayLap { get; set; }
        public string SoChungTu { get; set; }
        public int SoThuTu { get; set; }
        public string SoTien { get; set; }
        public string TyGia { get; set; }
        public string TongTien { get; set; }
        public string GhiChu { get; set; }
        public string NoiDung { get; set; }
        public int SoChungTuKemTheo { get; set; }
        public string DaGhiSo { get; set; }
        public string ThuChiTuQuy { get; set; }
        public int RepairingId { get; set; }
        public int SellingProductId { get; set; }
        public int ReceivingId { get; set; }
        public int ReturnProductId { get; set; }
        public string IsGotMoney { get; set; }
        public int MaLoaiThu { get; set; }
        public int NguoiNhanTien { get; set; }
        public DateTime NgayNhanTien { get; set; }

    }
}

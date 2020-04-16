using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace T.Model.Models
{
    [Table("BanMay")]
    class BanMays
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int BanMayID { get; set; }

        public string HoTen { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public int LoaiMay { get; set; }
        public string MoTaMay { get; set; }
        public DateTime CreatedDate { get; set; }
        public int AcceptBy { get; set; }
        public DateTime AcceptDate { get; set; }
        public string Note { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Model.Models
{
    [Table("ChiNhanhNH")]
    public class ChiNhanhNHs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]



        public int ChiNhanhNHId { get; set; }
        public int NganHangId { get; set; }
        public string TenChiNhanh { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }

    }
}

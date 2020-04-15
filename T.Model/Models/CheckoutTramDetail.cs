using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Model.Models
{
    [Table("CheckoutTramDetail")]
    public class CheckoutTramDetails
    {
        [Key]


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int CheckoutTramDetailId { get; set; }
        [Required] public int CheckoutTramId { get; set; }
        public int WarehouseId { get; set; }
        [Required] public int Amount { get; set; }
        public int MucDich { get; set; }
        public string ViTri { get; set; }
        public string Price { get; set; }
        public string TenKhachHang { get; set; }
        public string LyDo { get; set; }
        public string GhiChu { get; set; }
        public int ReturnAmount { get; set; }
        public int ProductId { get; set; }
        public int ProductSerialId { get; set; }

    }
}

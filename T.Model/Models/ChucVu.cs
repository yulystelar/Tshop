using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Model.Models
{
    [Table("ChucVu")]
    public class ChucVus
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]


        public int ChucVuId { get; set; }
        public string MaChucVu { get; set; }
        public string TenChucVu { get; set; }
        public string Code { get; set; }

    }
}

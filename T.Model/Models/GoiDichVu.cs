using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Model.Models
{
    [Table("GoiDichVu")]
    public class GoiDichVus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]



        public int GoiDichVuId { get; set; }
        public string TenGoi { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Model.Models
{
    [Table("DonViTinh")]
    public class DonViTinhs
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]


        public int DonViTinhId { get; set; }
        public string TenDonVi { get; set; }
        public string VietTat { get; set; }

    }
}

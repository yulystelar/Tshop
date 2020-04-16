using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Model.Models
{
    [Table("GiaoNhan")]
    public class GiaoNhans
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]



        public int GiaoNhanId { get; set; }
        public int RepairingId { get; set; }
        public int TechGiaoNhanId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        [Required] public string IsActive { get; set; }
        public int DeleteBy { get; set; }
        public DateTime DeleteDate { get; set; }

    }
}

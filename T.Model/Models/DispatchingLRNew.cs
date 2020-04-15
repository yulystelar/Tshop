using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Model.Models
{
    [Table("DispatchingLRNew")]
    public class DispatchingLRNews
    {
        [Key]


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int DispatchingLRNewId { get; set; }
        public int RepairingLRId { get; set; }
        public int TechnicianId { get; set; }
        [Required] public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public string IsActive { get; set; }
        public int DeleteBy { get; set; }
        public DateTime DeleteDate { get; set; }

    }
}

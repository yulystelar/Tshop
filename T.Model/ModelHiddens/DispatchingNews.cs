using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Model.Models
{
    [Table("DispatchingNew")]
    public class DispatchingNews
    {
        [Key]


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int DispatchingNewId { get; set; }
        public int Code { get; set; }
        public int RepairingId { get; set; }
        public int TechnicianId { get; set; }
        [Required] public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime GoDay { get; set; }
        public string Rate { get; set; }
        public string Money { get; set; }
        public string IsActive { get; set; }
        public int DeleteBy { get; set; }
        public DateTime DeleteDate { get; set; }

    }
}

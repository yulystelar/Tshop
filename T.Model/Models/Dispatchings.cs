using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Model.Models
{
    [Table("Dispatching")]
    public class Dispatchings
    {
        [Key]


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int DispatchingId { get; set; }
        public int RepairingId { get; set; }
        public int TechnicianId { get; set; }
        [Required] public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }

    }
}

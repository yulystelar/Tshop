using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Model.Models
{
    [Table("CallCenter")]
    public class CallCenters
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Callcenter { get; set; }

        public string FromNumber { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
      
    }
}

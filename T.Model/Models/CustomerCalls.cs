using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Model.Models
{
    [Table("CustomerCall")]
    public class CustomerCalls
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]


        public int CustomerCallId { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public int Ring { get; set; }
        public string Files { get; set; }
        public DateTime ToDay { get; set; }
        public DateTime EndDay { get; set; }
        public string Note { get; set; }
        public string Phone { get; set; }

    }
}

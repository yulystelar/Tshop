using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Model.Models
{
    [Table("Cabinet")]
    public class Cabinets
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int CabinetID { get; set; }

        public int WareHouseLocationID { get; set; }
        public string CabinetName { get; set; }
    }
}

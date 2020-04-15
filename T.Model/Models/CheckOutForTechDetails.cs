using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Model.Models
{
    [Table("CheckOutForTechDetail")]
    public class CheckOutForTechDetails
    {
        [Key]


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int CheckOutForTechDetailId { get; set; }
        public int CheckOutForTechId { get; set; }
        public int RepairingId { get; set; }
        public int WarehouseId { get; set; }
        public int ProductId { get; set; }
        public int ProductSerialId { get; set; }
        public string Price { get; set; }
        public int Amount { get; set; }
        public string TaxAmount { get; set; }
        [Required] public int PurposeId { get; set; }
        [Required] public int ReturnAmount { get; set; }
        public int TypeId { get; set; }
        [Required] public int ReAmountTemp { get; set; }

    }
}

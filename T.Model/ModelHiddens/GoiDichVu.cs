using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

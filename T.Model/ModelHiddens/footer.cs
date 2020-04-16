using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace T.Model.Models
{
    [Table("Footers")]
    public class Footerz
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public string ID { set; get; }
       
        [Required]
        public string Content { set; get; }
    }
}

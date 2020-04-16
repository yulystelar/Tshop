using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace T.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostId { set; get; }

        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string TagId { set; get; }

        [ForeignKey("PostId")]
        public virtual Post Post { set; get; }

        [ForeignKey("TagId")]
        public virtual Tag Tag { set; get; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace T.Model.Models
{
    [Table("VisitorStatistics")]
    internal class VisitorStatistic
    {
        [Key]
/*        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
*/        public int Id { set; get; }

        [Required]
        public DateTime VisitedDate { set; get; }

        [MaxLength(50)]
        public string IPAddress { set; get; }

    }
}
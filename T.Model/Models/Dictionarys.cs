using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Model.Models
{
    [Table("Dictionany")]
    public class Dictionanys
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]


        public int DictionanyId { get; set; }
        public int LanguageId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }

    }
}

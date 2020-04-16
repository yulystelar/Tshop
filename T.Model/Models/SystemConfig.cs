﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace T.Model.Models
{
    [Table("SystemConfigs")]
    public class SystemConfig
    {
        [Key]
        /*[DatabaseGenerated(DatabaseGeneratedOption.Identity)]*/
        public int Id { set; get; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string Code { set; get; }

        [MaxLength(256)]
        public string ValueString { set; get; }

        public int? ValueInt { set; get; }
    }
}
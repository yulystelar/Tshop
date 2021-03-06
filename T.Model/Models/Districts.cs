﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Model.Models
{
    [Table("District")]
    public class Districts
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]


        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public int NationalId { get; set; }
        public int ContinentId { get; set; }
        public string Image { get; set; }
        public string NameOther { get; set; }
        public string Code { get; set; }
        [Required] public string Name { get; set; }
        public string NameEN { get; set; }
        public string NameSearch { get; set; }
        public string Description { get; set; }
        public string Contents { get; set; }
        public int Status { get; set; }
        [Required] public string IsPublic { get; set; }

    }
}

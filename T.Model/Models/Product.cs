﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using T.Model.Abs;

namespace T.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { set; get; }
        [Required]
        [MaxLength(256)]

        public string Name { set; get; }
        [Required]
        [MaxLength(256)]

        public string Alias { set; get; }
        [Required]

        public int CatororyId { set; get; }
        [MaxLength(256)]
        public string Image { set; get; }
        public XElement MoreImages { set; get; }
        public decimal Price { set; get; }
        public decimal? PromotionPrice { set; get; }
        public int? Warranty { set; get; }
        [MaxLength(500)]

        public string Description { set; get; }
        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? hotFlag { set; get; }
        public int? ViewCount { set; get; }
        [ForeignKey("CateroryId")]

        public virtual ProductCategory ProductCategory { set; get; }
    }
}
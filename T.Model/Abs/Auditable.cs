using System;
using System.ComponentModel.DataAnnotations;

namespace T.Model.Abs
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedDate { set; get; }

        [MaxLength(256)]
        public string CreatedBy { set; get; }

        public DateTime? UpdatedDate { set; get; }

        [MaxLength(256)]
        public string UpdatedBy { set; get; }
        public bool Status { get; set; }
        [MaxLength(256)]
        public string MetaKeyword { set; get; }
        [MaxLength(256)]

        public string MetaDescription { set; get; }

    }
}
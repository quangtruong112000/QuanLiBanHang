namespace BaoCao
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhanQuyen")]
    public partial class PhanQuyen
    {
        [Key]
        [StringLength(10)]
        public string MaQuyen { get; set; }

        [Required]
        [StringLength(10)]
        public string TenQuyen { get; set; }

        [Column(TypeName = "text")]
        public string ChuThich { get; set; }
    }
}

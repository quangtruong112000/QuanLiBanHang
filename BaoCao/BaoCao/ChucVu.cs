namespace BaoCao
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChucVu")]
    public partial class ChucVu
    {
        [Key]
        [StringLength(10)]
        public string MaCV { get; set; }

        [Required]
        [StringLength(50)]
        public string TenCV { get; set; }
    }
}

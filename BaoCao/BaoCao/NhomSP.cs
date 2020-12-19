namespace BaoCao
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhomSP")]
    public partial class NhomSP
    {
        [Key]
        [StringLength(10)]
        public string MaNhomSP { get; set; }

        [Required]
        [StringLength(50)]
        public string TenNhomSP { get; set; }
    }
}

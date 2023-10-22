namespace DAL.context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ChiTiet_KS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaKS { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaSach { get; set; }

        public int? Soluong { get; set; }

        public virtual KhoSach KhoSach { get; set; }

        public virtual Sach Sach { get; set; }
    }
}

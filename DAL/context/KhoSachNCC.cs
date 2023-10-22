namespace DAL.context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhoSachNCC")]
    public partial class KhoSachNCC
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaNCC { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaSach { get; set; }

        public int? Soluong { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }

        public virtual Sach Sach { get; set; }
    }
}

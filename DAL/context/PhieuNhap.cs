namespace DAL.context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuNhap")]
    public partial class PhieuNhap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuNhap()
        {
            ChiTiet_PN = new HashSet<ChiTiet_PN>();
        }

        [Key]
        public int MaPN { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngaynhap { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNCC { get; set; }

        public int? ThanhTien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTiet_PN> ChiTiet_PN { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}

namespace DAL.context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            ChiTiet_HD = new HashSet<ChiTiet_HD>();
        }

        [Key]
        public int MaHD { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngaylap { get; set; }

        [Required]
        [StringLength(50)]
        public string TenTK { get; set; }

        public int? Thanhtien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTiet_HD> ChiTiet_HD { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}

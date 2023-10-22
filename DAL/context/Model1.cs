using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.context
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<ChiTiet_HD> ChiTiet_HD { get; set; }
        public virtual DbSet<ChiTiet_KS> ChiTiet_KS { get; set; }
        public virtual DbSet<ChiTiet_PN> ChiTiet_PN { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<GioHang> GioHangs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhoSach> KhoSaches { get; set; }
        public virtual DbSet<KhoSachNCC> KhoSachNCCs { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<TheLoai> TheLoais { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTiet_HD>()
                .Property(e => e.MaSach)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTiet_KS>()
                .Property(e => e.MaKS)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTiet_KS>()
                .Property(e => e.MaSach)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTiet_PN>()
                .Property(e => e.MaSach)
                .IsUnicode(false);

            modelBuilder.Entity<Feedback>()
                .Property(e => e.TenTK)
                .IsUnicode(false);

            modelBuilder.Entity<Feedback>()
                .Property(e => e.MaSach)
                .IsUnicode(false);

            modelBuilder.Entity<GioHang>()
                .Property(e => e.TenTK)
                .IsUnicode(false);

            modelBuilder.Entity<GioHang>()
                .Property(e => e.MaSach)
                .IsUnicode(false);

            modelBuilder.Entity<GioHang>()
                .Property(e => e.MaKS)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.TenTK)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.ChiTiet_HD)
                .WithRequired(e => e.HoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhoSach>()
                .Property(e => e.MaKS)
                .IsUnicode(false);

            modelBuilder.Entity<KhoSach>()
                .HasMany(e => e.ChiTiet_KS)
                .WithRequired(e => e.KhoSach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhoSach>()
                .HasMany(e => e.GioHangs)
                .WithRequired(e => e.KhoSach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhoSachNCC>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<KhoSachNCC>()
                .Property(e => e.MaSach)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .HasMany(e => e.KhoSachNCCs)
                .WithRequired(e => e.NhaCungCap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhaCungCap>()
                .HasMany(e => e.PhieuNhaps)
                .WithRequired(e => e.NhaCungCap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuNhap>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuNhap>()
                .HasMany(e => e.ChiTiet_PN)
                .WithRequired(e => e.PhieuNhap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.MaSach)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.MaTL)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .HasMany(e => e.ChiTiet_HD)
                .WithRequired(e => e.Sach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sach>()
                .HasMany(e => e.ChiTiet_KS)
                .WithRequired(e => e.Sach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sach>()
                .HasMany(e => e.ChiTiet_PN)
                .WithRequired(e => e.Sach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sach>()
                .HasMany(e => e.Feedbacks)
                .WithRequired(e => e.Sach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sach>()
                .HasMany(e => e.GioHangs)
                .WithRequired(e => e.Sach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sach>()
                .HasMany(e => e.KhoSachNCCs)
                .WithRequired(e => e.Sach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.TenTK)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Mk)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .HasMany(e => e.Feedbacks)
                .WithRequired(e => e.TaiKhoan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .HasMany(e => e.GioHangs)
                .WithRequired(e => e.TaiKhoan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.TaiKhoan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TheLoai>()
                .Property(e => e.MaTL)
                .IsUnicode(false);
        }
    }
}

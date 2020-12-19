namespace BaoCao
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class data : DbContext
    {
        public data()
            : base("name=data")
        {
        }

        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<CTHD> CTHDs { get; set; }
        public virtual DbSet<CTPhieuNhap> CTPhieuNhaps { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NhomSP> NhomSPs { get; set; }
        public virtual DbSet<PhanQuyen> PhanQuyens { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChucVu>()
                .Property(e => e.MaCV)
                .IsFixedLength();

            modelBuilder.Entity<CTHD>()
                .Property(e => e.MaHD)
                .IsFixedLength();

            modelBuilder.Entity<CTHD>()
                .Property(e => e.MaSP)
                .IsFixedLength();

            modelBuilder.Entity<CTPhieuNhap>()
                .Property(e => e.MaPN)
                .IsFixedLength();

            modelBuilder.Entity<CTPhieuNhap>()
                .Property(e => e.MaSP)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHD)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.SDTKH)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaNV)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SDTKH)
                .IsFixedLength();

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.MaNCC)
                .IsFixedLength();

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.SDTNCC)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaCV)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.GioiTinh)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.CMND)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDTNV)
                .IsFixedLength();

            modelBuilder.Entity<NhomSP>()
                .Property(e => e.MaNhomSP)
                .IsFixedLength();

            modelBuilder.Entity<PhanQuyen>()
                .Property(e => e.MaQuyen)
                .IsFixedLength();

            modelBuilder.Entity<PhanQuyen>()
                .Property(e => e.TenQuyen)
                .IsFixedLength();

            modelBuilder.Entity<PhanQuyen>()
                .Property(e => e.ChuThich)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuNhap>()
                .Property(e => e.MaPN)
                .IsFixedLength();

            modelBuilder.Entity<PhieuNhap>()
                .Property(e => e.MaNCC)
                .IsFixedLength();

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaSP)
                .IsFixedLength();

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaNhomSP)
                .IsFixedLength();

            modelBuilder.Entity<SanPham>()
                .Property(e => e.DonViTinh)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.MaQuyen)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}

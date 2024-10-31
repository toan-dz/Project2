using Quản_Lý_Sách.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web_Quản_lý_sách_trong_thư_viện.Models
{
    public class LibraryContext : DbContext
    {
        public DbSet<Sach> Sach { get; set; }
        public DbSet<TheLoai> TheLoai { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<GiaoDich> ThanhToan { get; set; }
        public DbSet<QuanTri> QuanTri { get; set; }

        public LibraryContext() : base("name=LibraryContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_Quản_lý_sách_trong_thư_viện.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLyThuVienEntities : DbContext
    {
        public QuanLyThuVienEntities()
            : base("name=QuanLyThuVienEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DOC_GIA> DOC_GIA { get; set; }
        public virtual DbSet<PHIEU_MUON> PHIEU_MUON { get; set; }
        public virtual DbSet<QUAN_TRI> QUAN_TRI { get; set; }
        public virtual DbSet<SACH> SACHes { get; set; }
        public virtual DbSet<THE_LOAI> THE_LOAI { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NhaHang_Web.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class NHAHANG_DOANWEBEntities : DbContext
    {
        public NHAHANG_DOANWEBEntities()
            : base("name=NHAHANG_DOANWEBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BANAN> BANAN { get; set; }
        public virtual DbSet<CHITIETDONHANG> CHITIETDONHANG { get; set; }
        public virtual DbSet<CHUCNANG> CHUCNANG { get; set; }
        public virtual DbSet<DANHGIA> DANHGIA { get; set; }
        public virtual DbSet<DATBAN> DATBAN { get; set; }
        public virtual DbSet<DONHANG> DONHANG { get; set; }
        public virtual DbSet<HOADON> HOADON { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANG { get; set; }
        public virtual DbSet<LOAIMONAN> LOAIMONAN { get; set; }
        public virtual DbSet<LOAINHANVIEN> LOAINHANVIEN { get; set; }
        public virtual DbSet<MONAN> MONAN { get; set; }
        public virtual DbSet<NguoiDung> NguoiDung { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIEN { get; set; }
        public virtual DbSet<PHANQUYEN> PHANQUYEN { get; set; }
        public virtual DbSet<PHANHOI> PHANHOI { get; set; }
    
        public virtual ObjectResult<SapXepMenu_Result> SapXepMenu(Nullable<int> giaMin, Nullable<int> giaMax, string sapXep)
        {
            var giaMinParameter = giaMin.HasValue ?
                new ObjectParameter("GiaMin", giaMin) :
                new ObjectParameter("GiaMin", typeof(int));
    
            var giaMaxParameter = giaMax.HasValue ?
                new ObjectParameter("GiaMax", giaMax) :
                new ObjectParameter("GiaMax", typeof(int));
    
            var sapXepParameter = sapXep != null ?
                new ObjectParameter("SapXep", sapXep) :
                new ObjectParameter("SapXep", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SapXepMenu_Result>("SapXepMenu", giaMinParameter, giaMaxParameter, sapXepParameter);
        }
    
        public virtual ObjectResult<SP_XemChiTietDonHang_Result> SP_XemChiTietDonHang(Nullable<int> mADH)
        {
            var mADHParameter = mADH.HasValue ?
                new ObjectParameter("MADH", mADH) :
                new ObjectParameter("MADH", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_XemChiTietDonHang_Result>("SP_XemChiTietDonHang", mADHParameter);
        }
    
        public virtual ObjectResult<SP_XemChiTietMonAn_Result> SP_XemChiTietMonAn(Nullable<int> mADH)
        {
            var mADHParameter = mADH.HasValue ?
                new ObjectParameter("MADH", mADH) :
                new ObjectParameter("MADH", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_XemChiTietMonAn_Result>("SP_XemChiTietMonAn", mADHParameter);
        }
    }
}

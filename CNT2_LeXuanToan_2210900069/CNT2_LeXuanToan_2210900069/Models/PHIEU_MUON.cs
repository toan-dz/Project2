//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CNT2_LeXuanToan_2210900069.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHIEU_MUON
    {
        public int MaPhieuMuon { get; set; }
        public Nullable<int> MaDocGia { get; set; }
        public Nullable<int> MaSach { get; set; }
        public System.DateTime NgayMuon { get; set; }
        public Nullable<System.DateTime> NgayTraDuKien { get; set; }
        public Nullable<System.DateTime> NgayTraThucTe { get; set; }
    
        public virtual DOC_GIA DOC_GIA { get; set; }
        public virtual SACH SACH { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLTV_DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHIEUTHUTIENPHAT
    {
        public string MaPhieuThuTP { get; set; }
        public string MaDocGia { get; set; }
        public decimal TongNo { get; set; }
        public Nullable<decimal> SoTienThu { get; set; }
        public decimal ConLai { get; set; }
    
        public virtual DOCGIA DOCGIA { get; set; }
    }
}

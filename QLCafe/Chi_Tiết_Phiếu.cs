//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLCafe
{
    using System;
    using System.Collections.Generic;
    
    public partial class Chi_Tiết_Phiếu
    {
        public string MaPhieu { get; set; }
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<decimal> ThanhTien { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
    
        public virtual Phiếu Phiếu { get; set; }
        public virtual Thực_Đơn Thực_Đơn { get; set; }
    }
}

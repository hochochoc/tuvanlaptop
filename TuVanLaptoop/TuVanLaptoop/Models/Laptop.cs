//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TuVanLaptoop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Laptop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MoTa { get; set; }
        public string AnhBia { get; set; }
        public Nullable<System.DateTime> NgayCapNhat { get; set; }
        public Nullable<int> HangLaptopId { get; set; }
        public Nullable<int> HeDieuHanhId { get; set; }
        public string mausac { get; set; }
        public Nullable<decimal> gia { get; set; }
        public Nullable<double> manhinh { get; set; }
        public Nullable<bool> dophangiai { get; set; }
        public string cpu { get; set; }
        public Nullable<int> ram { get; set; }
        public Nullable<int> ocung { get; set; }
        public Nullable<double> khoiluong { get; set; }
        public Nullable<double> pin { get; set; }
        public Nullable<bool> cardroi { get; set; }
    
        public virtual HangLapTop HangLapTop { get; set; }
        public virtual HeDieuHanh HeDieuHanh { get; set; }
    }
}
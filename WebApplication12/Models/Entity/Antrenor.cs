//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication12.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Antrenor
    {
        public short PersonelId { get; set; }
        public byte Alan1 { get; set; }
        public Nullable<byte> Alan2 { get; set; }
        public Nullable<byte> Alan3 { get; set; }
    
        public virtual Kurs Kurs { get; set; }
        public virtual Kurs Kurs1 { get; set; }
        public virtual Kurs Kurs2 { get; set; }
        public virtual Personel Personel { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VillaKiralama.DLL
{
    using System;
    using System.Collections.Generic;
    
    public partial class VillaDetay
    {
        public int VillaID { get; set; }
        public string OdaSayisi { get; set; }
        public int BanyoSayısı { get; set; }
        public decimal GunlukFiyat { get; set; }
        public bool HavuzluMu { get; set; }
        public bool MuhafazakarMı { get; set; }
        public int KişiSayisi { get; set; }
        public Nullable<bool> ÇocukHavuzuVarmi { get; set; }
        public Nullable<bool> DenizeYakinMi { get; set; }
        public Nullable<bool> HavuzuKorunakliMi { get; set; }
        public string Aciklama { get; set; }
    
        public virtual Villalar Villalar { get; set; }
    }
}

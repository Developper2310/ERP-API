using Microsoft.AspNetCore.Components.Routing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo1.Model
{
    public class Calisan
    {
        
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public DateTime IseBaslamaTarihi { get; set; }
        public int DepartmanID { get; set; }



        //relations
        public Departman? Departman { get; set; }
        public AlimSatim? AlimSatim { get; set; }
        public ICollection<KullaniciRol>? KullaniciRolleri { get; set; }
        public ICollection<KullaniciSifre>? KullaniciSifreleri { get; set; }
        public ICollection<KullaniciIslem>? KullaniciIslemleri { get; set; }
        public ICollection<AlimSatim>? AlimSatimlar { get; set; }
    }
}


//[Key]
//public int CalisanID { get; set; }

//[Required, MaxLength(50)]
//public string Ad { get; set; }

//[Required, MaxLength(50)]
//public string Soyad { get; set; }

//[Required, MaxLength(100)]
//public string Email { get; set; }

//[MaxLength(20)]
//public string Telefon { get; set; }

//[MaxLength(255)]
//public string Adres { get; set; }

//public DateTime IseBaslamaTarihi { get; set; }

//public int DepartmanID { get; set; }
//public Departman Departman { get; set; }

//public int RolID { get; set; }
//public Rol? Rol { get; set; }
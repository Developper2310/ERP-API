namespace Demo1.Model
{
    public class KullaniciIslem
    {

        public int Id { get; set; }
        public DateTime IslemTarihi { get; set; }

        // Foreign Keys
        public int CalisanID { get; set; }
        public int IslemID { get; set; }

        // Navigation Properties
        public Calisan? Calisan { get; set; }
        public Islem? Islem { get; set; }
    }
}

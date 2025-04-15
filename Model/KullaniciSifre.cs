namespace Demo1.Model
{
    public class KullaniciSifre
    {
        public int Id { get; set; }
        public int CalisanID { get; set; }
        public string Sifre { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public bool Aktif { get; set; }
        //
        public Calisan? Calisan { get; set; }
    }
}

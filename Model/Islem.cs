namespace Demo1.Model
{
    public class Islem
    {
        public int Id { get; set; }
        public string IslemAdi { get; set; }
        public string Aciklama { get; set; }

        public ICollection<KullaniciIslem> KullaniciIslemleri { get; set; }
       // public List<KullaniciIslem> KullaniciIslemleri { get; set; } = new();
    }
}

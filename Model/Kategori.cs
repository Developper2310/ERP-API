namespace Demo1.Model
{
    public class Kategori
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }

        public ICollection<Urun> Urunler { get; set; }
    }
}


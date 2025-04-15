namespace Demo1.Model
{
    public class Urun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public int KategoriID { get; set; }
        public int MarkaID { get; set; }
        public decimal Fiyat { get; set; }


        public Kategori? Kategori { get; set; }
        public Marka? Marka { get; set; }
        public ICollection<DepoUrun> DepoUrunleri { get; set; }
        public ICollection<FisDestek> FisDestekler { get; set; }
    }
}

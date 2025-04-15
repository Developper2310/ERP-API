namespace Demo1.Model
{
    public class Depo
    {
        public int Id { get; set; }
        public string DepoAdi { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }

        public ICollection<DepoUrun> DepoUrunleri { get; set; }
        public ICollection<AlimSatim> AlimSatimlar { get; set; }
    }
}

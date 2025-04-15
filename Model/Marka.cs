namespace Demo1.Model
{
    public class Marka
    {
        public int Id { get; set; }
        public string MarkaAdi { get; set; }
        //
        public ICollection<Urun> Urunler { get; set; }
    }
}

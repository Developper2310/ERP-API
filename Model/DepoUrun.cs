namespace Demo1.Model
{
    public class DepoUrun
    {
        public int DepoId { get; set; }
        public int UrunID { get; set; }
        public int Miktar { get; set; }

        public Urun Urun { get; set; }
        public Depo Depo { get; set; } 
    }
}

namespace Demo1.Model
{
    public class FisDestek
    {
        public int AlimSatimID { get; set; }
        public int UrunID { get; set; }
        public int Adet { get; set; }
       

        public AlimSatim? AlimSatim { get; set; }
        public Urun? Urun { get; set; }

    }
}

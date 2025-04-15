namespace Demo1.Model
{
    public class AlimSatim
    {
        public int Id { get; set; }
        public int CalisanID { get; set; }
        public DateTime IslemTarihi { get; set; }

        public string IslemTipi { get; set; }
        public int DepoID  { get; set; }

        public Depo? Depo { get; set; }
        public Calisan? Calisan { get; set; }
        public ICollection<FisDestek>? FisDestekler { get; set; }
    }
}

using Demo1.DTOs.EkDTOlar;

namespace Demo1.DTOs
{
    public class UrunDto 
    {
        public int Id { get; set; }
        public string? UrunAdi { get; set; }
        public int KategoriID { get; set; }
        public int MarkaID   { get; set; }
        public decimal Fiyat { get; set; }
    }
}

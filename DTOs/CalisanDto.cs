using Demo1.DTOs.EkDTOlar;

namespace Demo1.DTOs
{
    public class CalisanDto 
    {
        public int Id { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? Email { get; set; }
        public string? Telefon { get; set; }
        public string? Adres { get; set; }
        public DateTime IseBaslamaTarihi { get; set; }


        public int DepartmanID { get; set; }
    }
}

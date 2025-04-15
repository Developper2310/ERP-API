using Demo1.DTOs.EkDTOlar;

namespace Demo1.DTOs
{
    public class RolDto 
    {
        public int RolID { get; set; }
        public string? RolAdi { get; set; }

        public List<YetkiDto> Yetkiler { get; set; }//kaldırılabilir
    }
}

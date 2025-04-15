using Demo1.DTOs.EkDTOlar;
using Demo1.Model;

namespace Demo1.DTOs
{
    public class AlimSatimDto 
    {
        public int Id { get; set; }
        public int CalisanID { get; set; }
   
        public DateTime IslemTarihi { get; set; }
        public string? IslemTipi { get; set; }

        //
        public int DepoID { get; set; }



        public List<FisDestek>? FisDestekler { get; set; }//dto yap
    }
}

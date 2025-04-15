namespace Demo1.Model
{
    public class KullaniciRol
    {
        
        public int CalisanID { get; set; }
        public int RolID { get; set; }

        //One-Many
        public Calisan? Calisan { get; set; }
        public Rol? Rol { get; set; }
    }

}

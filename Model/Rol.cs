namespace Demo1.Model
{
    public class Rol
    {
        public int Id { get; set; }
        public string RolAdi { get; set; }

        public ICollection<KullaniciRol> KullaniciRolleri { get; set; }
        public ICollection<RolYetki> RolYetkileri { get; set; }
    }

}

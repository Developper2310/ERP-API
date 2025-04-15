namespace Demo1.Model
{
    public class Yetki
    {
        public int Id { get; set; }
        public string YetkiAdi { get; set; }
        public string Aciklama { get; set; }

        public ICollection<RolYetki>? RolYetkileri { get; set; }
    }
}

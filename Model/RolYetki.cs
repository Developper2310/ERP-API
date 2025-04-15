namespace Demo1.Model
{
    public class RolYetki
    {
        public int Id { get; set; }
        public int RolID { get; set; }
        public int YetkiID { get; set; }

        public Rol? Rol { get; set; }
        public Yetki? Yetki { get; set; }
    }
}

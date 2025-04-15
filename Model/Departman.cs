namespace Demo1.Model
{
    public class Departman
    {
        public int Id { get; set; }
        public string DepartmanAdi { get; set; }

        public ICollection<Calisan> Calisanlar { get; set; }
    }
}

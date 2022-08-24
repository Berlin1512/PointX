namespace PointX.Entities
{
    public class Nation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Province> Provinces { get; set; }
    }
}

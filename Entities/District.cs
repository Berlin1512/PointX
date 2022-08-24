namespace PointX.Entities
{
    public class District
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Province Provinces { get; set; }
        public ICollection<Ward> Wards { get; set; }
    }
}

namespace PointX.Entities
{
    public class Street
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<WardStreet> Ward_Street { get; set; }
    }
}

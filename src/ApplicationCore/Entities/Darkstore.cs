namespace ApplicationCore.Entities
{
    public class Darkstore
    {
        public int DarkstoreId { get; set; }
        public string? Name { get; set; }

        public List<Employee>? Employees { get; set; }
    }
}

namespace ApplicationCore.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Position { get; set; }
        public string? AccountNumber { get; set; }

        public int DarkstoreId { get; set; }
        public Darkstore? Darkstore { get; set; }
    }
}

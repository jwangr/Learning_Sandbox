namespace CoreEmpty.Models // matches folder structure
{
    public class Person
    {
        public Guid Id { get; set; } // universally unique ID number
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public int Age { get; set; }
    }
}
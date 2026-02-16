using System.ComponentModel.DataAnnotations;

namespace CoreEmpty.Models // matches folder structure
{
    public class Person
    {
        public Guid Id { get; set; } // universally unique ID number

        [Required(ErrorMessage = "Knock knock, who's there")] // set custom error message
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, Email: {Email}, phone: {Phone}, Age: {Age}";
        }
    }
}
namespace CoreEmpty.Models
{
    public class Book
    {
        public int? BookId { get; set; }
        public string? Author { get; set; }

        public override string ToString() // override the default ToString() method
        {
            return $"Book id {BookId} and author: {Author}";
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace ExOfModels.Models
{
    public class Book
    {
        [FromQuery]

        public int? bookId { get; set; }
        public string? author { get; set; }

        public override string ToString()
        {
            return $"Book object is BookId:{bookId} and author:{author}";
        }

    }
}

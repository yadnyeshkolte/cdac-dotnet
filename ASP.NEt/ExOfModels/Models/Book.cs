using Microsoft.AspNetCore.Mvc;

namespace ExOfModels.Models
{
    public class Book
    {
        // this is not the poco class Plain Old CLR Object`
        // if we remove the [FromQuery] it will be categorised as the POCO class

        [FromQuery]
        public int? bookId { get; set; }
        public string? author { get; set; }

        public override string ToString()
        {
            return $"Book object is BookId:{bookId} and author:{author}";
        }

    }
}

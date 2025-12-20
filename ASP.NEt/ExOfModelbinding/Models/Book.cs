using Microsoft.AspNetCore.Mvc;

namespace ExOfModelbinding.Models
{
    public class Book
    {
        [FromRoute]
        public int bookId {
            set; get;
        }
        public string author {
            set; get;
        }
        public string title {
            set; get;
        }

        public override string ToString()
        {
            return $"Book is {bookId} {author} {title}";
        }
    }
}

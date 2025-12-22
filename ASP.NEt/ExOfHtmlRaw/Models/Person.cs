namespace ExOfHtmlRaw.Models
{
    public class Person
    {
        public string? name { get; set;}
        public DateTime dob { get; set; }

        public Gender personGender { get; set; }

    }
    public enum Gender {
        Male, Female, Others
    }
}

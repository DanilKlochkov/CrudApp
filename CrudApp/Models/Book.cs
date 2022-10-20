namespace CrudApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public int Year { get; set; }

        public virtual Author Author { get; set; }
    }
}
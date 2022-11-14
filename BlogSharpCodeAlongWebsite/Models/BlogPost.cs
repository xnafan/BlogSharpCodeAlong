namespace BlogSharpCodeAlongWebsite.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; } = "untitled";
        public string Content { get; set; } = "No content";
        public DateTime CreationTime { get; set; }
        public int AuthorId { get; set; }
    }
}

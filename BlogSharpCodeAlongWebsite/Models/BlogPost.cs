using System.ComponentModel.DataAnnotations;

namespace BlogSharpCodeAlongWebsite.Models
{
    public class BlogPost
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = "untitled";

        [Required]
        public string Content { get; set; } = "No content";
        public DateTime CreationTime { get; set; }
        public int AuthorId { get; set; }
    }
}

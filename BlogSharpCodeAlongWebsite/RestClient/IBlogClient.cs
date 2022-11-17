namespace BlogSharpCodeAlongWebsite.RestClient
{
    public interface IBlogClient
    {
        BlogPostDto GetById(int id);
        IEnumerable<BlogPostDto> GetAll();
        int Insert(BlogPostDto blogPost);
        bool Update(BlogPostDto blogPost);
        bool Delete(BlogPostDto blogPost);
    }
}

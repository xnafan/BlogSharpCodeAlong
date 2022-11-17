namespace BlogSharpWebApi.DataAccess;

public interface IBlogPostDao
{
    BlogPost GetById(int id);
    IEnumerable<BlogPost> GetAll();
    int Insert(BlogPost blogPost);
    bool Update(BlogPost blogPost);
    bool Delete(BlogPost blogPost);
}

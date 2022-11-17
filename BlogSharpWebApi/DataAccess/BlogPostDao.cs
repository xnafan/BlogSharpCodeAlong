
namespace BlogSharpWebApi.DataAccess;

internal class BlogPostDao : IBlogPostDao
{


    public bool Delete(BlogPost blogPost)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<BlogPost> GetAll()
    {
        return new List<BlogPost>() { 
        new BlogPost(){Title = "Great post", Id=1 }
        };
    }

    public BlogPost GetById(int id)
    {
        throw new NotImplementedException();
    }

    public int Insert(BlogPost blogPost)
    {
        throw new NotImplementedException();
    }

    public bool Update(BlogPost blogPost)
    {
        throw new NotImplementedException();
    }
}
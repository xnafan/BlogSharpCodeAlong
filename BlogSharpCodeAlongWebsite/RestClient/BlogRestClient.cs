namespace BlogSharpCodeAlongWebsite.RestClient
{
    public class BlogRestClient : IBlogClient
    {
        private RestSharp.RestClient _client;

        public BlogRestClient(string url) => _client = new RestSharp.RestClient(url);

        public bool Delete(BlogPostDto blogPost)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BlogPostDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public BlogPostDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(BlogPostDto blogPost)
        {
            throw new NotImplementedException();
        }

        public bool Update(BlogPostDto blogPost)
        {
            throw new NotImplementedException();
        }
    }
}

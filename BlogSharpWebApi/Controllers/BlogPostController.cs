using BlogSharpWebApi.DataAccess;
using Microsoft.AspNetCore.Mvc;


namespace BlogSharpWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {
        IBlogPostDao _blogPostDao;

        public BlogPostController(IBlogPostDao blogPostDao)
        {
            _blogPostDao = blogPostDao;
        }



        // GET: api/<BlogPostController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BlogPostController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpGet("{id}")]
        public string GetByEmail(string partOfEmail)
        {
            return "value";
        }


        // POST api/<BlogPostController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BlogPostController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BlogPostController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

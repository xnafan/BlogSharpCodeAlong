using BlogSharpCodeAlongWebsite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogSharpCodeAlongWebsite.Controllers
{
    public class HomeController : Controller
    {

         readonly static List<BlogPost> blogPostList = new List<BlogPost>()
            {
                new BlogPost(){Id = 1, AuthorId=7, Title="awesome blogpost", Content="awesome content awesome content awesome content awesome content awesome content awesome content awesome content awesome content ", CreationTime = DateTime.Now.AddDays(-4) },
                 new BlogPost(){Id = 2, AuthorId=7, Title="awesomer blogpost", Content="awesome content awesome content awesome content awesome content awesome content awesome content awesome content awesome content ", CreationTime = DateTime.Now.AddDays(-4) },
                  new BlogPost(){Id = 3, AuthorId=7, Title="awesomest blogpost", Content="awesome content awesome content awesome content awesome content awesome content awesome content awesome content awesome content ", CreationTime = DateTime.Now.AddDays(-4) }
            };
        public ActionResult Index()
        {
            return View(blogPostList);
        }
        public ActionResult Details(int id)
        {
            return View(blogPostList.First(blogPost => blogPost.Id == id));
        }

        [Authorize]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BlogPost blogPost)
        {
            try
            {
                blogPost.Id = blogPostList.Max(post => post.Id) +1;
                blogPost.CreationTime = DateTime.Now;
                blogPostList.Add(blogPost);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            return View(blogPostList.First(blogPost => blogPost.Id == id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, BlogPost blogPost)
        {
            try
            {
                var itemToEdit = blogPostList.First(post => post.Id == id);
                itemToEdit.Title = blogPost.Title;
                itemToEdit.Content = blogPost.Content;
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Delete(int id)
        {
            return View(blogPostList.First(blogPost => blogPost.Id == id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, BlogPost post)
        {
            try
            {
                blogPostList.RemoveAll(blogPost => blogPost.Id == id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

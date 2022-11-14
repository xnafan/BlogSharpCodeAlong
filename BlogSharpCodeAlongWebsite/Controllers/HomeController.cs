﻿using BlogSharpCodeAlongWebsite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogSharpCodeAlongWebsite.Controllers
{
    public class HomeController : Controller
    {

        private readonly static List<BlogPost> blogPostList = new List<BlogPost>()
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
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Delete(int id)
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

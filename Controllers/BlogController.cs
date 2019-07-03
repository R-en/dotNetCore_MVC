using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using exploreCalifornia.Models;

namespace exploreCalifornia.Controllers
{
    [Route("blog")]

    public class BlogController : Controller
    {
        private readonly BlogDataContext _db;

        public BlogController(BlogDataContext db){
            _db = db;
        }
        
        [Route("")]
        public IActionResult Index()
        {
           var posts = new[]
            {
                new Post
                {
                    Title = "My blog post",
                    Posted = DateTime.Now,
                    Author = "Jess Chadwick",
                    Body = "This is a great blog post, don't you think?",
                },
                new Post
                {
                    Title = "My second blog post",
                    Posted = DateTime.Now,
                    Author = "Jess Chadwick",
                    Body = "This is ANOTHER great blog post, don't you think?",
                },
            };

            return View(posts);
        }

        [Route("{year:min(2000)}/{month:range(1,12)}/{key}")]
         public IActionResult Post(int year, int month, string key)
        {
            var post = new Post{
                Title = "My Blog post",
                Posted = DateTime.Now,
                Author = "Jess Chadwick",
                Body ="This is a great Post! Don't you think?",
            };

            return View(post);
        }

        [HttpGet, Route("create")]
        public IActionResult Create(){
            return View();
        }

        [HttpPost, Route("create")]
        public IActionResult Create(Post post){
            if(!ModelState.IsValid){
                return View();
            }
            post.Author = User.Identity.Name;
            post.Posted = DateTime.Now;

            _db.Posts.Add(post);
            _db.SaveChanges();
            
            return View();
        }


        // public IActionResult Privacy()
        // {
        //     return View();
        // }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}

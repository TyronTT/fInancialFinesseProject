using fInancialFinesseProject.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Construction;

namespace fInancialFinesseProject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        public List<BlogPost> Posts { get; set; } = new List<BlogPost>()
        {
            new BlogPost {Url = "new-Tutorial", Title="A New Tutorial about Blazor with Web API", Description="This is a new tutorial, showing you how to build a blog with Blazor", Content="adssadsadsadsadasdsadsadsadsadsadsadsadsadsadsadsadasdsadsa"},
            new BlogPost {Url = "first-post", Title="My First Blog Post with Web API", Description="Hi! This is my new blog. Enjoy!", Content="This is my new beautiful post!"}
        };

        [HttpGet]
        public ActionResult<List<BlogPost>> GimmeAllTheBlogPost()
        {
            return Ok(Posts);
        }

        [HttpGet("{url}")]
        public ActionResult<BlogPost> GimmeThatSingleBlogPost(string url)
        {
            var post = Posts.FirstOrDefault(p => p.Url.ToLower().Equals(url.ToLower()));
            if(post == null)
            {
                return NotFound("This Post Does Not Exist.");
            }

            return Ok(post);
        }
    }
}

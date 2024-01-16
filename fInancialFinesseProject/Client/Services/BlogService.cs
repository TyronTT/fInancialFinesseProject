using fInancialFinesseProject.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace fInancialFinesseProject.Client.Services
{
    public class BlogService : IBlogService
    {
        public List<BlogPost> Posts { get; set; } = new List<BlogPost>()
        {
            new BlogPost {Url = "new-Tutorial", Title="A New Tutorial about Blazor", Description="This is a new tutorial, showing you how to build a blog with Blazor", Content="adssadsadsadsadasdsadsadsadsadsadsadsadsadsadsadsadasdsadsa"},
            new BlogPost {Url = "first-post", Title="My First Blog Post", Description="Hi! This is my new blog. Enjoy!", Content="This is my new beautiful post!"}
        };
        public BlogPost GetBlogPostByUrl(string url)
        {
            return Posts.FirstOrDefault(p => p.Url.ToLower().Equals(url.ToLower()));
        }

        public List<BlogPost> GetBlogPosts()
        {
            return Posts;
        }
    }
}

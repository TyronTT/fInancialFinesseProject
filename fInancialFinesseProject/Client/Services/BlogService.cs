﻿using fInancialFinesseProject.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Reflection.Metadata.Ecma335;

namespace fInancialFinesseProject.Client.Services
{
    public class BlogService : IBlogService
    {
        private readonly HttpClient _http;

        public BlogService(HttpClient http)
        {
                _http = http;
        }

        public async Task<BlogPost> GetBlogPostByUrl(string url)
        {
            var post = await _http.GetFromJsonAsync<BlogPost>($"api/Blog/{url}");
            return post;
        }

        public async Task<List<BlogPost>> GetBlogPosts()
        {
            return await _http.GetFromJsonAsync<List<BlogPost>>($"api/Blog");
        }
    }
}

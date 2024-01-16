using fInancialFinesseProject.Shared.Domain;

namespace fInancialFinesseProject.Client.Services
{
    interface IBlogService
    {
        List<BlogPost> GetBlogPosts();
        BlogPost GetBlogPostByUrl(string url);
    }
}

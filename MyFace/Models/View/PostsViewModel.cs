using System.Collections.Generic;
using System.Linq;
using MyFace.Models.Database;

namespace MyFace.Models.View
{
    public class PostsViewModel
    {
        public IEnumerable<PostViewModel> Posts { get; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPosts { get; set; }

        public PostsViewModel(IEnumerable<Post> posts, int pageNumber, int pageSize, int totalPosts)
        {
            Posts = posts.Select(post => new PostViewModel(post));
            PageNumber = pageNumber;
            PageSize = pageSize;
            TotalPosts = totalPosts;
        }
    }
}
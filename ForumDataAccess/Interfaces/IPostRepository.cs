using ForumDomain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForumDataAccess.Interfaces
{
    public interface IPostRepository
    {
        List<Post> GetAllPosts();
        Task<Post> GetPostById(int id);
        Task AddPost(Post post);
        void EditPost(Post post);
        void DeletePost(int id);
        List<Post> GetPostsByForum(int id);
    }
}

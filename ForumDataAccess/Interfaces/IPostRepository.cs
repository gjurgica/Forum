using ForumDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForumDataAccess.Interfaces
{
    public interface IPostRepository
    {
        List<Post> GetAllPosts();
        Post GetPostById(int id);
        void AddPost(Post post);
        void EditPost(Post post);
        void DeletePost(int id);
        List<Post> GetPostsByForum(int id);
    }
}

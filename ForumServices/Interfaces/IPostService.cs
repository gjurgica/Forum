using ForumViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForumServices.Interfaces
{
    public interface IPostService
    {
        IEnumerable<PostViewModel> GetAllPosts();
        PostViewModel GetPostById(int id);
        void CreatePost(PostViewModel post);
        void EditPost(PostViewModel post);
        void DeletePost(int id);
        IEnumerable<PostViewModel> GetPostsByForum(int id);
    }
}

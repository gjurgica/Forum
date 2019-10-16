using ForumViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForumServices.Interfaces
{
    public interface IPostService
    {
        IEnumerable<PostViewModel> GetAllPosts();
        PostViewModel GetPostById(int id);
        void CreatePost(CreatePostViewModel post);
        void EditPost(PostViewModel post);
        void DeletePost(int id);
        IEnumerable<PostViewModel> GetPostsByThread(int id);
        List<PostViewModel> GetPaginatedResult(List<PostViewModel> list,int currentPage, int pageSize = 3);
        int GetCount();
    }
}

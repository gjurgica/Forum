using Forum.DomainClasses.Models;
using Forum.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Services.Interfaces
{
    public interface IPostService
    {
        IEnumerable<PostViewModel> GetAllPost();
        PostViewModel GetPostById(string id);
        void CreatePost(PostViewModel post);
        void ChangePost(PostViewModel post);
        void MovePost(string postId, string threadId);
        void DeletePost(string id);
    }
}

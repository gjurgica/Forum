using ForumViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForumServices.Interfaces
{
    public interface IPostReplyService
    {
        IEnumerable<PostReplyViewModel> GetAllReplies();
        PostReplyViewModel GetReplyById(int id);
        void CreatePostReply(PostReplyViewModel post);
        void EditPostReply(PostReplyViewModel post);
        void DeletePostReply(int id);
    }
}

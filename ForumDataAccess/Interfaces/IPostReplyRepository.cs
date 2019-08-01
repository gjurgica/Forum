using ForumDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForumDataAccess.Interfaces
{
    public interface IPostReplyRepository
    {
        List<PostReply> GetAllReplies();
        PostReply GetReplyById(int id);
        void EditReply(PostReply reply);
        void AddReply(PostReply reply);
        void DeleteReply(int id);
    }
}

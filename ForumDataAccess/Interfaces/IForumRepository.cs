using ForumDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForumDataAccess.Interfaces
{
    public interface IForumRepository
    {
        List<Forum> GetAllForums();
        Forum GetForumById(int id);
        void AddForum(Forum forum);
        void EditForum(Forum forum);
        void DeleteForum(int id);
    }
}

using ForumDomain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForumDataAccess.Interfaces
{
    public interface IForumRepository
    {
        IEnumerable<Forum> GetAllForums();
        Task<Forum> GetForumById(int id);
        Task AddForum(Forum forum);
        void EditForum(Forum forum);
        void DeleteForum(int id);
    }
}

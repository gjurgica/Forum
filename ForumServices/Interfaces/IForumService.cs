using ForumViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForumServices.Interfaces
{
    public interface IForumService
    {
        IEnumerable<ForumViewModel> GetAllForums();
        ForumViewModel GetForumById(int id);
        void CreateForum(ForumViewModel forum);
        void EditForum(ForumViewModel forum);
        void DeleteForum(int id);
    }
}

using ForumViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForumServices.Interfaces
{
    public interface IThreadService
    {
        IEnumerable<ThreadViewModel> GetAllThreads();
        ThreadViewModel GetThreadById(int id);
        void CreateThread(ThreadViewModel thread);
        void EditThread(ThreadViewModel thread);
        void DeleteThread(int id);
    }
}

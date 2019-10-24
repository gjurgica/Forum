using Forum.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Services.Interfaces
{
    public interface IThreadService
    {
        IEnumerable<ThreadViewModel> GetAllThreads();
        ThreadViewModel GetThreadById(string id);
        void CreateThread(ThreadViewModel entity);
        void DeleteThread(string id);
        void UpdateThread(ThreadViewModel entity);
        void MoveThread(string categoryId, string threadId);
    }
}

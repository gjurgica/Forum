using Forum.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Services.Interfaces
{
    public interface IPrivateMessageService
    {
        IEnumerable<PrivateMessageViewModel> GetAllMessages();
        PrivateMessageViewModel GetMessageById(string id);
        void CreatePrivateMessage(PrivateMessageViewModel privateMessage);
        void DeletePrivateMessage(string id);
    }
}

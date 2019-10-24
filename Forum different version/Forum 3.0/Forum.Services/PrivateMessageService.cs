using AutoMapper;
using Forum.DataAccess.Interfaces;
using Forum.DomainClasses.Models;
using Forum.Services.Interfaces;
using Forum.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Services
{
    public class PrivateMessageService : IPrivateMessageService
    {
        private readonly IRepository<PrivateMessage> _privateMessageRepository;
        private readonly IMapper _mapper;

        public PrivateMessageService(IRepository<PrivateMessage> privateMessageRepository, IMapper mapper)
        {
            _privateMessageRepository = privateMessageRepository;
            _mapper = mapper;
        }

        public void CreatePrivateMessage(PrivateMessageViewModel privateMessage)
        {
            _privateMessageRepository.Insert(_mapper.Map<PrivateMessage>(privateMessage));
        }

        public void DeletePrivateMessage(string id)
        {
            PrivateMessage privateMessage = _privateMessageRepository.GetById(id);
            if (privateMessage == null)
                throw new Exception("The private message does not exist");

            _privateMessageRepository.Delete(id);
        }

        public IEnumerable<PrivateMessageViewModel> GetAllMessages()
        {
            return _mapper.Map<IEnumerable<PrivateMessageViewModel>>(_privateMessageRepository.GetAll());
        }

        public PrivateMessageViewModel GetMessageById(string id)
        {
            PrivateMessage privateMessage = _privateMessageRepository.GetById(id);
            if (privateMessage == null)
                throw new Exception("The private message does not exist");

            return _mapper.Map<PrivateMessageViewModel>(privateMessage);
        }
    }
}

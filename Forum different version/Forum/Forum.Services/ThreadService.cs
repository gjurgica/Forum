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
    public class ThreadService : IThreadService
    {
        private readonly IRepository<Thread> _threadRepository;

        private readonly IMapper _mapper;

        public ThreadService(IRepository<Thread> threadRepository, IMapper mapper)
        {
            _threadRepository = threadRepository;
            _mapper = mapper;
        }

        public void CreateThread(ThreadViewModel entity)
        {
            _threadRepository.Insert(_mapper.Map<Thread>(entity));
        }

        public void DeleteThread(string id)
        {
            Thread thread = _threadRepository.GetById(id);
            if (thread == null)
                throw new Exception("Thread does not exist");

            _threadRepository.Delete(id);
        }

        public IEnumerable<ThreadViewModel> GetAllThreads()
        {
            return _mapper.Map<IEnumerable<ThreadViewModel>>(_threadRepository.GetAll());
        }

        public ThreadViewModel GetThreadById(string id)
        {
            Thread thread = _threadRepository.GetById(id);

            if (thread == null)
                throw new Exception("Thread does't exist.");

            return _mapper.Map<ThreadViewModel>(thread);
        }

        public void UpdateThread(ThreadViewModel entity)
        {
            Thread thread = _mapper.Map<Thread>(_threadRepository.GetById(entity.Id));

            thread.Title = entity.Title;

            _threadRepository.Update(thread);
        }

        public void MoveThread(string categoryId, string threadId)
        {
            Thread thread = _threadRepository.GetById(threadId);

            thread.CategoryId = categoryId;
        }
    }
}

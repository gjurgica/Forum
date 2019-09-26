using AutoMapper;
using ForumDataAccess.Interfaces;
using ForumDomain;
using ForumServices.Interfaces;
using ForumViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForumServices.Services
{
    public class ThreadService : IThreadService
    {
        private readonly IRepository<Thread> _threadService;
        private readonly IMapper _mapper;

        public ThreadService(IRepository<Thread> threadService, IMapper mapper)
        {
            _threadService = threadService;
            _mapper = mapper;
        }
        public void CreateThread(ThreadViewModel thread)
        {

            _threadService.Insert(_mapper.Map<Thread>(thread));
        }

        public void DeleteThread(int id)
        {
            _threadService.Delete(id);
        }

        public void EditThread(ThreadViewModel thread)
        {
            _threadService.Update(_mapper.Map<Thread>(thread));
        }

        public IEnumerable<ThreadViewModel> GetAllThreads()
        {
           return _threadService.GetAll().Select(x => _mapper.Map<ThreadViewModel>(x)).ToList();
        }

        public ThreadViewModel GetThreadById(int id)
        {
            var thread = _threadService.GetById(id);
            if (thread == null)
            {

                throw new Exception("Forum does not exist");
            }
            return _mapper.Map<ThreadViewModel>(thread);
        }
    }
}

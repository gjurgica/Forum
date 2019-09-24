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
    public class ForumService : IForumService
    {
        private readonly IRepository<Forum> _forumService;
        private readonly IMapper _mapper;

        public ForumService(IRepository<Forum> forumService, IMapper mapper)
        {
            _forumService = forumService;
            _mapper = mapper;
        }
        public void CreateForum(ForumViewModel forum)
        {

            _forumService.Insert(_mapper.Map<Forum>(forum));
        }

        public void DeleteForum(int id)
        {
            _forumService.Delete(id);
        }

        public void EditForum(ForumViewModel forum)
        {
            _forumService.Update(_mapper.Map<Forum>(forum));
        }

        public IEnumerable<ForumViewModel> GetAllForums()
        {
           return  _forumService.GetAll().Select(x => _mapper.Map<ForumViewModel>(x)).ToList();
        }

        public ForumViewModel GetForumById(int id)
        {
            var forum = _forumService.GetById(id);
            if (forum == null)
            {

                throw new Exception("Forum does not exist");
            }
            return _mapper.Map<ForumViewModel>(forum);
        }
    }
}

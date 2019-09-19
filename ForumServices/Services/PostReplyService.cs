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
    public class PostReplyService : IPostReplyService
    {
        private readonly IRepository<PostReply> _postReplyService;
        private readonly IMapper _mapper;

        public PostReplyService(IRepository<PostReply> postReplyService, IMapper mapper)
        {
            _postReplyService = postReplyService;
            _mapper = mapper;
        }
        public void CreatePostReply(PostReplyViewModel post)
        {
            _postReplyService.Insert(_mapper.Map<PostReply>(post));
        }

        public void DeletePostReply(int id)
        {
            _postReplyService.Delete(id);
        }

        public void EditPostReply(PostReplyViewModel post)
        {
            _postReplyService.Update(_mapper.Map<PostReply>(post));
        }

        public IEnumerable<PostReplyViewModel> GetAllReplies()
        {
            return _postReplyService.GetAll().Select(x => _mapper.Map<PostReplyViewModel>(x)).ToList();
        }

        public PostReplyViewModel GetReplyById(int id)
        {
            var post = _postReplyService.GetById(id);
            if(post == null)
            {
                throw new Exception("Reply does not exist");
            }

            return _mapper.Map<PostReplyViewModel>(post);
        }
    }
}

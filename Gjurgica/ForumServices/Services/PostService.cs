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
    public class PostService : IPostService
    {
        private readonly IPostRepository<Post> _postService;
        private readonly IMapper _mapper;

        public PostService(IPostRepository<Post> postService, IMapper mapper)
        {
            _postService = postService;
            _mapper = mapper;
        }
        public void CreatePost(PostViewModel post)
        {
            _postService.Insert(_mapper.Map<Post>(post));
        }

        public void DeletePost(int id)
        {
            _postService.Delete(id);
        }

        public void EditPost(PostViewModel post)
        {
            _postService.Update(_mapper.Map<Post>(post));
        }

        public IEnumerable<PostViewModel> GetAllPosts()
        {
            return _postService.GetAll().Select(x => _mapper.Map<PostViewModel>(x)).ToList();
        }

        public PostViewModel GetPostById(int id)
        {
            var post = _postService.GetById(id);
            if(post == null)
            {
                throw new Exception("Post does not exist");
            }
            return _mapper.Map<PostViewModel>(post);
        }

        public IEnumerable<PostViewModel> GetPostsByThread(int id)
        {
            return _postService.GetPostsByThread(id).Select(x => _mapper.Map<PostViewModel>(x)).ToList();
        }
    }
}

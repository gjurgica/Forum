using AutoMapper;
using Forum.DataAccess.Interfaces;
using Forum.DataAccess.Repositories;
using Forum.DomainClasses.Models;
using Forum.Services.Interfaces;
using Forum.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Services
{
    public class PostService : IPostService
    {
        private readonly IRepository<Post> _postRepository;
        private readonly IMapper _mapper;

        public PostService(IRepository<Post> postrepository, IMapper mapper)
        {
            _postRepository = postrepository;
            _mapper = mapper;
        }

        public void ChangePost(PostViewModel post)
        {
            _postRepository.Update(_mapper.Map<Post>(post));
        }

        public void CreatePost(PostViewModel post)
        {
            _postRepository.Insert(_mapper.Map<Post>(post));
        }

        public void DeletePost(string id)
        {
            Post post = _postRepository.GetById(id);
            if (post == null)
                throw new Exception("Post does not exist");

            _postRepository.Delete(id);
        }

        public IEnumerable<PostViewModel> GetAllPost()
        {
            return _mapper.Map<IEnumerable<PostViewModel>>(_postRepository.GetAll());
        }

        public PostViewModel GetPostById(string id)
        {
            Post post = _postRepository.GetById(id);
            if (post == null)
                throw new Exception("Post does not exist");

            return _mapper.Map<PostViewModel>(post);
        }

        public void MovePost(string postId, string threadId)
        {
            Post post = _postRepository.GetById(postId);

            post.ThreadId = threadId;

            _postRepository.Update(post);
        }
    }
}

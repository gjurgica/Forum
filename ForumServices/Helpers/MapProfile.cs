using AutoMapper;
using ForumDomain;
using ForumViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForumServices.Helpers
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Forum, ForumViewModel>();
            CreateMap<Post, PostViewModel>();
            CreateMap<PostReply, PostReplyViewModel>();
            CreateMap<User, UserViewModel>();
            CreateMap<User, RegisterViewModel>();
        }
    }
}

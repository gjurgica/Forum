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
            CreateMap<Forum, ForumViewModel>().ReverseMap();
            CreateMap<Post, PostViewModel>().ReverseMap();
            CreateMap<PostReply, PostReplyViewModel>().ReverseMap();
            CreateMap<User, UserViewModel>().ReverseMap();
            CreateMap<RegisterViewModel, User>();
        }
    }
}

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
            CreateMap<Forum, ForumViewModel>()
                .ForMember(fv => fv.User, src => src.MapFrom(f => f.User))
                .ForMember(fv => fv.Created, src => src.UseValue(DateTime.UtcNow))
                .ReverseMap()
                .ForMember(f => f.Created, src => src.UseValue(DateTime.UtcNow))
                .ForMember(f => f.User, src => src.Ignore());
            CreateMap<Post, PostViewModel>()
                .ForMember(p => p.User, src => src.MapFrom(pv => pv.User))
                .ForMember(p => p.Forum, src => src.MapFrom(pv => pv.Forum))
                .ReverseMap()
                .ForMember(p => p.UserId, src => src.MapFrom(pv => pv.User.Id))
                .ForMember(p => p.ForumId, src => src.MapFrom(pv => pv.Forum.Id))
                .ForMember(p => p.Created, src => src.UseValue(DateTime.UtcNow))
                .ForMember(p => p.User, src => src.Ignore())
                .ForMember(p => p.Forum, src => src.Ignore())
                .ForMember(p => p.Replies, src => src.Ignore());
            CreateMap<PostReply, PostReplyViewModel>().ReverseMap();
            CreateMap<User, UserViewModel>().ReverseMap();
            CreateMap<RegisterViewModel, User>()
                .ForMember(u => u.EmailConfirmed, src => src.UseValue(true));
        }
    }
}

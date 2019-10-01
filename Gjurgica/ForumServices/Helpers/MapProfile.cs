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
            CreateMap<Thread, ThreadViewModel>()
                .ForMember(fv => fv.Created, src => src.UseValue(DateTime.UtcNow.Date))
                .ForMember(t => t.Category, src => src.MapFrom(tv => tv.Category))
                .ForMember(t => t.Posts, src => src.MapFrom(tv => tv.Posts))
                .ReverseMap()
                .ForMember(tv => tv.Id, src => src.Ignore());
            CreateMap<Post, PostViewModel>()
                .ForMember(p => p.User, src => src.MapFrom(pv => pv.User))
                .ForMember(p => p.Thread, src => src.MapFrom(pv => pv.Thread))
                .ReverseMap()
                .ForMember(p => p.Id, src => src.Ignore())
                .ForMember(p => p.UserId, src => src.MapFrom(pv => pv.User.Id))
                .ForMember(p => p.ThreadId, src => src.MapFrom(pv => pv.Thread.Id))
                .ForMember(p => p.User, src => src.Ignore())
                .ForMember(p => p.Thread, src => src.Ignore())
                .ForMember(p => p.Replies, src => src.Ignore());
            CreateMap<PostReply, PostReplyViewModel>()
                .ForMember(p => p.User, src => src.MapFrom(pv => pv.User))
                .ForMember(p => p.Post, src => src.MapFrom(pv => pv.Post))
                .ReverseMap()
                .ForMember(p => p.Id, src => src.Ignore())
                .ForMember(p => p.UserId, src => src.MapFrom(pv => pv.User.Id))
                .ForMember(p => p.PostId, src => src.MapFrom(pv => pv.Post.Id))
                .ForMember(p => p.User, src => src.Ignore())
                .ForMember(p => p.Post, src => src.Ignore());
            CreateMap<User, UserViewModel>()
                .ReverseMap()
                .ForMember(uv => uv.Id,src => src.Ignore())
                .ForMember(u => u.EmailConfirmed, src => src.UseValue(true));
            CreateMap<RegisterViewModel, User>()
                .ForMember(u => u.EmailConfirmed, src => src.UseValue(true));
            CreateMap<Category, CategoryViewModel>()
                .ForMember(c => c.Threads,src => src.MapFrom(cv => cv.Threads))
                .ReverseMap();
        }
    }
}

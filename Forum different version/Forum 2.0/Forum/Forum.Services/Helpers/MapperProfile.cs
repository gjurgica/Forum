using AutoMapper;
using Forum.DomainClasses.Models;
using Forum.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Services.Helpers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<RegisterViewModel, User>()
                .ForMember(u => u.FullName, src => src.ResolveUsing(rm => $"{rm.FirstName} {rm.LastName}"))
                .ForMember(u => u.EmailConfirmed, src => src.UseValue(true))
                .ReverseMap();
            CreateMap<User, UserViewModel>()
                .ReverseMap();
            CreateMap<Thread, ThreadViewModel>()
                .ReverseMap();
            CreateMap<Post, PostViewModel>()
                .ReverseMap();
            CreateMap<Category, CategoryViewModel>();
            CreateMap<PrivateMessage, PrivateMessageViewModel>()
                .ReverseMap();
            CreateMap<Alert, AlertViewModel>()
                .ReverseMap();

        }
    }
}

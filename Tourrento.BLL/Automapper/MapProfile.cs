using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tourrento.DAL.Models;

namespace Tourrento.BLL.Automapper
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<User, Shared.Dto.User>().ReverseMap();

            CreateMap<Category, Shared.Dto.Category>().ReverseMap();

            CreateMap<Item, Shared.Dto.Item>()
                .ForMember(e => e.Available, a => a.MapFrom(s =>s.RentedItems.Where(
                    c => c.ItemId == s.Id && c.Rent.RentalDate <= DateTimeOffset.Now && c.Rent.UntilDate >= DateTimeOffset.Now)))
                .ReverseMap();

            CreateMap<Post, Shared.Dto.Post>()
                .ForMember(e => e.QuestionerName, a => a.MapFrom(s => s.Questioner.Name))
                .ForMember(e => e.QuestionerUserName, a => a.MapFrom(s => s.Questioner.UserName))
                .ReverseMap();

            CreateMap<Rent, Shared.Dto.Rent>()
                .ForMember(e => e.FullName, a => a.MapFrom(s => s.User.Name))
                .ForMember(e => e.Items, a => a.MapFrom(s => s.RentedItems.Select(f => f.Item).ToList()))
                .ReverseMap();

            CreateMap<Service, Shared.Dto.Service>().ReverseMap();

            CreateMap<Tour, Shared.Dto.TourDetails>()
                .ForMember(e => e.CreatorName, a => a.MapFrom(s => s.Creator.Name))
                .ForMember(e => e.ParticipatedCount, a => a.MapFrom(s => s.ParticipateTours.Count()))
                .ForMember(e => e.Services, a => a.MapFrom(s => s.TourServices.Select(f => f.Service).ToList()))
                .ForMember(e => e.RequiredCategories, a => a.MapFrom(s => s.RequiredCategoryTours.Select(f => f.RequiredCategory).ToList()))
                .ReverseMap();

            CreateMap<Tour, Shared.Dto.TourPreview>().ReverseMap();
        }
    }
}

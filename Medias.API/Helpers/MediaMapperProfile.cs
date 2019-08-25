using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medias.API.Helpers
{
    public class MediaMapperProfile : Profile
    {
        public MediaMapperProfile()
        {
            CreateMap<Entities.Media, Model.MediaModel>().ForMember(x => x.MediaGroup, opt => opt.MapFrom(
               src => $"{src.MediaGroup.Name}:{src.MediaGroupId}"))
                .ForMember(x => x.Title, opt => opt.MapFrom(src => $"{src.MediaGroup.Name} - {src.Title}"));
        }     
    }
}

using AutoMapper;
using Entities;
using Data.ViewModels;

namespace Data
{
  /// <summary>
  /// Profile is a container around any mappings you want to setup. 
  /// 
  /// </summary>
  public class DutchMappingProfile : Profile
  {
    public DutchMappingProfile()
    {
      /*CreateMap<Order, OrderViewModel>()
        .ForMember(ov => ov.OrderId,
        map => map.MapFrom(o => o.Id))
        .ReverseMap();

      CreateMap<OrderItem, OrderItemViewModel>().ReverseMap();*/
    }
  }
}

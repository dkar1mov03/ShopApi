using AutoMapper;
using MyLearningProject.Domain.Entities.OrderItems;
using MyLearningProject.Domain.Entities.Orders;
using MyLearningProject.Domain.Entities.Products;
using MyLearningProject.Domain.Entities.Users;
using MyLearningProject.Service.DTOs.OrderItems;
using MyLearningProject.Service.DTOs.Orders;
using MyLearningProject.Service.DTOs.Products;
using MyLearningProject.Service.DTOs.Users;
namespace MyLearningProject.Service.Mappers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserForUpdateDto>().ReverseMap();
        CreateMap<User, UserForResultDto>().ReverseMap();
        CreateMap<User, UserForCreationDto>().ReverseMap();

        CreateMap<Product, ProductForUpdateDto>().ReverseMap();
        CreateMap<Product,ProductForCreationDto>().ReverseMap();
        CreateMap<Product,ProductForResultDto>().ReverseMap();

        CreateMap<OrderItem,OrderItemForCreationDto>().ReverseMap();
        CreateMap<OrderItem, OrderItemForResultDto>().ReverseMap();
        CreateMap<OrderItem,OrderItemForUpdateDto>().ReverseMap();

        CreateMap<Order, OrderForCreationDto>().ReverseMap();
        CreateMap<Order, OrderForResultDto>().ReverseMap();
        CreateMap<Order, OrderForUpdateDto>().ReverseMap();
    }
}

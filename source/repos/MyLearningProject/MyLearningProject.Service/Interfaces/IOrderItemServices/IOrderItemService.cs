using MyLearningProject.Service.DTOs.OrderItems;
using MyLearningProject.Service.DTOs.Orders;

namespace MyLearningProject.Service.Interfaces.IOrderItemServices;

public interface IOrderItemService
{
    public Task<OrderItemForResultDto> CreateAsync(OrderForCreationDto dto);
    public Task<OrderItemForResultDto> UpdateAsync(OrderItemForUpdateDto dto);
    public Task<bool> RemoveAsync(long  id);
    public Task<OrderItemForResultDto> RetrieveAsync(long id);
    public Task<IEnumerable<OrderItemForResultDto>> RetrieveAllAsync();
}

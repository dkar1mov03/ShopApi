using MyLearningProject.Service.DTOs.Orders;

namespace MyLearningProject.Service.Interfaces.IOrderServices;

public interface IOrderService
{
    public Task<OrderForResultDto> CreateAsync(OrderForCreationDto dto);
    public Task<OrderForResultDto> UpdateAsync(OrderForUpdateDto dto);
    public Task<bool> RemoveAsync(long  id);
    public Task<OrderForResultDto> RetrieveByIdAsync(long id);
    public Task<IEnumerable<OrderForResultDto>> RetrieveAllAsync();
}

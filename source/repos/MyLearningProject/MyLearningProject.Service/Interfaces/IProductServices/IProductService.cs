using MyLearningProject.Service.DTOs.Products;

namespace MyLearningProject.Service.Interfaces.IProductServices;

public interface IProductService
{
    public Task<ProductForResultDto> CreationAsync(ProductForCreationDto dto);
    public Task<ProductForResultDto> UpdateAsync(ProductForUpdateDto dto);
    public Task<bool> RemoveAsync(long id);
    public Task<ProductForResultDto> RerieveByIdAsync(long id);
    public Task<IEnumerable<ProductForResultDto>> RetrieveAllAsync();
}

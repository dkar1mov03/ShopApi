using MyLearningProject.Service.DTOs.Users;

namespace MyLearningProject.Service.Interfaces.IUserServices;

public interface IUserService
{
    public Task<UserForResultDto> CreationAsync(UserForCreationDto dto);
    public Task<UserForResultDto> UpdateAsync(UserForUpdateDto dto);
    public Task<bool> RemoveAsync (long  id);
    public Task<UserForResultDto> RetrieveByIdAsync(long id);
    public Task<IEnumerable<UserForResultDto>> RetrieveAllAsync();
}

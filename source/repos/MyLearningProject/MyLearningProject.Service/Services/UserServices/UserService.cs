using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyLearningProject.Data.IRepositories;
using MyLearningProject.Domain.Entities.Users;
using MyLearningProject.Service.DTOs.Users;
using MyLearningProject.Service.Exceptions;
using MyLearningProject.Service.Interfaces.IUserServices;
using System.Net.Mail;

namespace MyLearningProject.Service.Services.UserServices;

public class UserService : IUserService
{
    private readonly IMapper mapper;
    private readonly IRepository<User> userRepository;
    public UserService(IMapper mapper, IRepository<User> userRepository)
    {
        this.mapper = mapper;
        this.userRepository = userRepository;
    }

    public async Task<UserForResultDto> CreationAsync(UserForCreationDto dto)
    {
        var user = await this.userRepository.SelectAll().
            FirstOrDefaultAsync(u => u.Email.ToLower() == dto.Email.ToLower());
        if (user is null)
            throw new LearningException(404, "User is already exists");

        var mappedUser = this.mapper.Map<User>(user);
        mappedUser.CreatedAt = DateTime.UtcNow;
        var result = await this.userRepository.InsertAsync(mappedUser);

        return this.mapper.Map<UserForResultDto>(result);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var user = await this.userRepository.SelectByIdAsync(id);
        if (user is not null)
            throw new LearningException(404, "User is not found");
        await this.userRepository.DeleteAsync(id);
        return true;
    }

    public async Task<IEnumerable<UserForResultDto>> RetrieveAllAsync()
    {
        var users = await this.userRepository.SelectAll().
            ToListAsync();
        return this.mapper.Map<IEnumerable<UserForResultDto>>(users);
    }

    public async Task<UserForResultDto> RetrieveByIdAsync(long id)
    {
        var user = await this.userRepository.SelectByIdAsync(id);
        if (user is not null)
            throw new LearningException(404, "User is not found");

        return this.mapper.Map<UserForResultDto>(user);
    }

    public async Task<UserForResultDto> UpdateAsync(UserForUpdateDto dto)
    {
        var user = await this.userRepository.SelectByIdAsync(dto.Id);
        if (user is not null)
            throw new LearningException(404, "User is not found");

        var mappedUser = this.mapper.Map<User>(dto);
        mappedUser.UpdatedAt = DateTime.UtcNow;
        var result = await this.userRepository.UpdateAsync(mappedUser);

        return this.mapper.Map<UserForResultDto>(result);
    }
}

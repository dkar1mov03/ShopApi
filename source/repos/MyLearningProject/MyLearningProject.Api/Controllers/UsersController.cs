using Microsoft.AspNetCore.Mvc;
using MyLearningProject.Service.DTOs.Users;
using MyLearningProject.Service.Interfaces.IUserServices;

namespace MyLearningProject.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController
    {
        private readonly IUserService userService;
        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpGet]
        public async Task<List<UserForResultDto>> GetAll()
        {
            var users = await this.userService.RetrieveAllAsync();
            return users.ToList();
        }
        [HttpGet("{id}")]
        public async Task<UserForResultDto> GetAsync(long id)
        {
            var user = await this.userService.RetrieveByIdAsync(id);
            return user;
        }
        [HttpPost]
        public async Task<UserForResultDto> PostAsync(UserForCreationDto dto)
        {
            var user = await this.userService.CreationAsync(dto);
            return user;
        }
        [HttpDelete("{id}")]
        public async Task<bool> DeleteAsync(long id)
        {
            var user = await this.userService.RemoveAsync(id);
            return user;
        }
        [HttpPut]
        public async Task<UserForResultDto> PutAsync(UserForUpdateDto dto)
        {
            var user = await this.userService.UpdateAsync(dto);
            return user;
        }
    }
}

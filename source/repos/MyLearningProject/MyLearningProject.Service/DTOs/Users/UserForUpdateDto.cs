﻿namespace MyLearningProject.Service.DTOs.Users;

public class UserForUpdateDto
{
    public long Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}

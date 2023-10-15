﻿using MyLearningProject.Domain.Commons;

namespace MyLearningProject.Domain.Entities.Users;

public class User : Auditable
{
    public long UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

}

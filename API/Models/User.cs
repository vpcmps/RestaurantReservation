﻿namespace API.Data;

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public string Role { get; set; }
}

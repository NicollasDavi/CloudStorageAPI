﻿namespace CloudStorage.Domain.Entities;
public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string AccesToken { get; set; } = string.Empty;
    public string RefreshToken { get; set; } = string.Empty;
}

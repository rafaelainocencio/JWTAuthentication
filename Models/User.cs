using System;

public class User
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; } //deve estar encriptado
    public string Role { get; set; } //deve ser uma lista, pois pode haver vários

    public User()
	{
	}
}

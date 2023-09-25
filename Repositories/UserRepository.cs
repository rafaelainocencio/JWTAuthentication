using System;
using System.Collections.Generic;
using System.Linq;

public static class UserRepository
{
    public static User Get(string username, string password)
    {
        var users = new List<User>();
        users.Add(new User { Id = 1, UserName = "Barbie", Password = "Barbie", Role = "Manager" });
        users.Add(new User { Id = 2, UserName = "Raquelle", Password = "Raquelle", Role = "employee" });

        return users
            .Where(x => 
            x.UserName == username
            && x.Password == password).FirstOrDefault();
    }
}

using System;
using System.Collections.Generic;

public class User
{
    private static List<string> registeredUsers = new List<string>();

    public static bool IsUserRegistered(string username)
    {
        return registeredUsers.Contains(username);
    }

    public static void RegisterUser(string username)
    {
        if (!registeredUsers.Contains(username))
        {
            registeredUsers.Add(username);
        }
    }
}

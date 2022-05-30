using System;
using System.Collections.Generic;

namespace UserDB
{
    public class UserDatabase
    {
        List<User> _users = new List<User>();

        public bool AddUser(User user)
        {
            if(user.Age > 100 || user.Age < 18) 
            {
                throw new Exception("User should be older than 18 years old and younger than 100 years old");
            }
            if(user.Name == "Bad Guy")
            {
                throw new Exception("User should not be Bad Guy. I don't like this song.");
            }
            if (!user.Email.Contains("@"))
            {
                throw new Exception("Invalid email");
            }

            _users.Add(user);
            return true;
        }

    }
}

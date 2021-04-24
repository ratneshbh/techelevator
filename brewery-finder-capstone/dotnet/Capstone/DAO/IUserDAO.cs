﻿using Capstone.Models;
using System;
using System.Collections.Generic;

namespace Capstone.DAO
{
    public interface IUserDAO
    {
        IList<User> GetUsers();
        User GetUser(string username);
        User AddUser(string username, string password, string role,string firstName,string lastName,string email,DateTime dob);

        ReturnUser UpdateUserUser(int active,int user_id);
        ReturnUser UpdateUserAdmin(int active,string role, int user_id);
        List<ReturnUser> GetReturnUserList();

    }
}

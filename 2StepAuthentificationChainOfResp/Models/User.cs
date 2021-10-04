﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2StepAuthentificationChainOfResp.Models
{
    public class User
    {
        public User(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
        }
        public User()
        {

        }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}

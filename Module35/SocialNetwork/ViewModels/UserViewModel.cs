﻿using SocialNetwork.Models;

namespace SocialNetwork.ViewModels
{
    public class UserViewModel
    {
        public User User { get; set; }

        public UserViewModel(User user)
        {
            User = user;
        }
    }
}

using SocialNetwork.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialNetwork.Models;

namespace SocialNetwork.ViewModels
{
    public class MainViewModel
    {
        public RegisterViewModel RegisterView { get; set; }

        public LoginViewModel LoginView { get; set; }

        public UserViewModel UserView { get; set; }

        public MainViewModel()
        {
            RegisterView = new RegisterViewModel();
            LoginView = new LoginViewModel();
            UserView = new UserViewModel(new User());
        }
    }
}
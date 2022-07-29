using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.ViewModels
{
    public class LoginVM
    {
        [Required,StringLength(20)]
        public string UserName { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        public bool Rememberme { get; set; }
    }
}


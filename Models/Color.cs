using System;
using System.ComponentModel.DataAnnotations;
using OnlineShop.Models.Base;

namespace OnlineShop.Models
{
    public class Color:BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}


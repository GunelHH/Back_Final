using System;
using System.ComponentModel.DataAnnotations;
using OnlineShop.Models.Base;

namespace OnlineShop.Models
{
    public class Size:BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}


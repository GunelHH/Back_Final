using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using OnlineShop.Models.Base;

namespace OnlineShop.Models
{
    public class Category : BaseEntity
    {
        [Required(ErrorMessage = "Please enter the category name")]
        public string Name { get; set; }

        public string Image { get; set; }

        public List<Clothe> Clothe { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}


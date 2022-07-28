using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using OnlineShop.Models.Base;

namespace OnlineShop.Models
{
    public class Slider:BaseEntity
    {
        public string Image { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Desc { get; set; }

        [Required]
        public string ButtonScript { get; set; }

        [Required]
        public byte Order { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }

    }
}


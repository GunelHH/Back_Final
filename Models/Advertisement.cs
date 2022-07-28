using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using OnlineShop.Models.Base;

namespace OnlineShop.Models
{
    public class Advertisement:BaseEntity
    {
        public string Image { get; set; }

        public string Save { get; set; }

        [Required ,StringLength(maximumLength:60)]
        public string Title { get; set; }

        [Required]
        public string ButtonScript { get; set; }

        public byte Order { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }

    }
}


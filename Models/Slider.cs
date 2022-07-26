using System;
using System.ComponentModel.DataAnnotations;
using OnlineShop.Models.Base;

namespace OnlineShop.Models
{
    public class Slider:BaseEntity
    {
        [Required]
        public string Image { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Desc { get; set; }

        [Required]
        public string ButtonScript { get; set; }

        [Required]
        public byte Order { get; set; }

    }
}


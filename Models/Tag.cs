using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using OnlineShop.Models.Base;

namespace OnlineShop.Models
{
    public class Tag:BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public List<Clothe> Clothe { get; set; }
    }
}


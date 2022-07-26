using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using OnlineShop.Models.Base;

namespace OnlineShop.Models
{
    public class ClotheInformation:BaseEntity
    {
        [Required, StringLength(40)]
        public string Title { get; set; }

        [Required]
        public string Desc { get; set; }

        public List<Clothe> Clothe { get; set; }
    }
}


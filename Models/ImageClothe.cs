using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using OnlineShop.Models.Base;

namespace OnlineShop.Models
{
    public class ImageClothe:BaseEntity
    {
        [Required(ErrorMessage = "Name of Image is Required!")]
        public string Name { get; set; }

        [Required]
        public string Alternative { get; set; }

        [Required]
        public bool? IsMain { get; set; }

        public int ClotheId { get; set; }

        public Clothe Clothe { get; set; }


        //public IFormFile mainPhoto { get; set; }
    }
}



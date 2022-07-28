using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using OnlineShop.Models.Base;

namespace OnlineShop.Models
{
    public class Clothe:BaseEntity
    {
        [Required(ErrorMessage = "Please enter Name,cause it's required"), StringLength(maximumLength: 20)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter Price,cause it's required")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please enter Description of Product")]
        public string Desc { get; set; }

        public List<ImageClothe> ImageClothes { get; set; }

        public int ClotheInformationId { get; set; }

        public ClotheInformation ClotheInformation { get; set; }

        public int TagId { get; set; }

        public Tag Tag { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }


        [NotMapped]
        public int ClotheImageIds { get; set; }

        [NotMapped]
        public IFormFile MainImage { get; set; }

        [NotMapped]
        public List<IFormFile> SecondaryImages { get; set; }


    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using OnlineShop.Models.Base;

namespace OnlineShop.Models
{
    public class Clothe:BaseEntity
    {
        [Required(ErrorMessage ="Please enter Name,cause it's required"),StringLength(maximumLength:20)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter Price,cause it's required")]
        public decimal Price { get; set; }

        [Required(ErrorMessage ="Please enter Description of Product")]
        public string Desc { get; set; }

        public List<Image> Images { get; set; }

        public int ClotheInformationId { get; set; }

        public ClotheInformation ClotheInformation { get; set; }


    }
}


using System;
using System.ComponentModel.DataAnnotations;
using OnlineShop.Models.Base;

namespace OnlineShop.Models
{
    public class ImageClothe:BaseEntity
    {
        [Required(ErrorMessage = "Name of Image is Required!")]
        public string Name { get; set; }

        public string Alternative { get; set; }

        public bool? IsMain { get; set; }

        public int ClotheId { get; set; }

        public Clothe Clothe { get; set; }
    }
}



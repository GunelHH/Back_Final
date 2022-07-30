using System;
using System.ComponentModel.DataAnnotations;
using OnlineShop.Models.Base;

namespace OnlineShop.Models
{
    public class Message:BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required,DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Subject { get; set; }

        [Required]
        public string Body { get; set; }

    }
}


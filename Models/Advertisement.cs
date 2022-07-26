using System;
using OnlineShop.Models.Base;

namespace OnlineShop.Models
{
    public class Advertisement:BaseEntity
    {
        public string Image { get; set; }

        public string Save { get; set; }

        public string Title { get; set; }

        public string ButtonScript { get; set; }

    }
}


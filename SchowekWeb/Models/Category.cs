using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SchowekWeb.Data;

namespace SchowekWeb.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string CategoryName { get; set; }

        public byte[] Icon { get; set; }

        [Required]
        public DateTime OnCreated { get; set; }

        public ICollection<Item> Items { get; set; }

        public string UserId { get; set; }
        public AspNetUsers AspNetUsers { get; set; }
    }
}

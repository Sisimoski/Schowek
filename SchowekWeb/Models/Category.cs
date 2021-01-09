using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SchowekWeb.Data;

namespace SchowekWeb.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string CategoryName { get; set; }

        public string Icon { get; set; }

        [Required]
        public DateTime OnCreated { get; set; }

        public ICollection<Item> Items { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}

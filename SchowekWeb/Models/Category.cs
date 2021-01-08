using System;
using System.Collections.Generic;
using SchowekWeb.Data;

namespace SchowekWeb.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public byte Icon { get; set; }
        public DateTime OnCreated { get; set; }

        public ICollection<Item> Items { get; set; }

        public string UserId { get; set; }
        public AspNetUsers AspNetUsers { get; set; }
    }
}

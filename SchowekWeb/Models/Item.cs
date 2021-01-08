﻿using System;
using SchowekWeb.Data;

namespace SchowekWeb.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileType { get; set; }
        public string FileSize { get; set; }
        public string Text { get; set; }
        public DateTime OnCreated { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public string UserId { get; set; }
        public AspNetUsers AspNetUsers { get; set; }

    }
}
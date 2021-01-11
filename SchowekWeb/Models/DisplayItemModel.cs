using System;
using System.ComponentModel.DataAnnotations;

namespace SchowekWeb.Models
{
    public class DisplayItemModel
    {
        public string Text { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileType { get; set; }
        public string FileSize { get; set; }
    }
}

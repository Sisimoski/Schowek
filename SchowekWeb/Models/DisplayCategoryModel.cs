using System;
using System.ComponentModel.DataAnnotations;

namespace SchowekWeb.Models
{
    public class DisplayCategoryModel
    {
        [Required(ErrorMessage = "Wprowadź nazwę.")]
        [MinLength(1, ErrorMessage = "Za krótka nazwa.")]
        public string CategoryName { get; set; }

        public string Icon { get; set; }
    }
}

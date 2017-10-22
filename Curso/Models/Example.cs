using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Curso.Models
{
    public class Example
    {
        [Key]
        public Int32 ExampleID { get; set; }
        [Required(ErrorMessage = "The Title is required")]
        [Display(Name = "Title")]
        public String Title { get; set; }
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "The Description is required.")]
        [Display(Name = "Description")]
        public String Description { get; set; }
    }
}
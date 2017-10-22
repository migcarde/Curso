using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Curso.Models
{
    public class Speaker
    {

        public Int32 SpeakerID { get; set; }
        [Required(ErrorMessage = "The Speaker is required")]
        [Display(Name="Speaker")]
        public String Name { get; set; }
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public String EmailAddress { get; set; }
        //public virtual List<Session> Sessions { get; set; }
    }
}
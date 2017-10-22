using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Curso.Models
{
    public class Session
    {
        public Int32 SessionID { get; set; }
        [Required()]
        public String Title { get; set; }
        [Required()]
        [DataType(DataType.MultilineText)]
        public String Abstract { get; set; }
        public Int32 SpeakerID { get; set; }
        public virtual Speaker Speaker { get; set; } //Se utiliza la propiedad virtual ya que es una proviene de la clase Speaker y es más óptimo tenerlo con la propiedad virtual  
    }
}
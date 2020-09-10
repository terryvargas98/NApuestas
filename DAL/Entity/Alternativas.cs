using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entity
{
 public class Alternativas
    {
        [Key]
        public int id { get; set; }
        public int idPregunta { get; set; }
        public string alternativa1  {get; set; }
        public string alternativa2 { get; set; }
        public string alternativa3 { get; set; }
        public string alternativa4 { get; set; }
    }
}

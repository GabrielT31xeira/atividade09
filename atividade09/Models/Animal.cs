using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace atividade09.Models
{
    public abstract class Animal
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string regiao { get; set; }
        public string familia { get; set; }
        public string quantidade_patas { get; set; }
        public bool anfibio { get; set; }
    }
}
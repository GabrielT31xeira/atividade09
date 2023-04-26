using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace atividade09.Models
{
    public class Invertebrados : Animal
    {
        public string classe { get; set; }
        public string categoria { get; set; }
        public string exoesqueleto { get; set; }
        public string tamanho_centimetros { get; set; }
    }
}
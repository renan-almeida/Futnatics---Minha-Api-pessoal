using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgApi.Models
{
    public class Cliente
    {
        public int Id {get; set; }
        public string Nome {get; set;}
        public int Idade {get; set;}
        public string Genero {get; set;}
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Futnatics.Models
{
    public class Setor
    {
        public int Id {get; set; }
        public string Nome {get; set;}
        public double Capacidade { get; set; }
        
        public Partida Partida { get; set; }
        public int IdPartida { get; set; }
        
    }
}
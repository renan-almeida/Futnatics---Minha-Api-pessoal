using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Futnatics.Models
{
    public class Ingresso
    {
        public int Id {get; set; }
        public double Preco {get; set;}
        public string NomeCliente { get; set; }
        public Partida Partida { get; set; }
        public int IdPartida { get; set; }
        public string DataCompraIngresso { get; set; }
       
        
    }
}
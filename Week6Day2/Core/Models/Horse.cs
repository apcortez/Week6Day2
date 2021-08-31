using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Day2.Core.Models
{
    public class Horse
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Relazione 1 a 1 con cavaliere
        public int KnightId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Day2.Core.Models
{
    public class Battle
    {
        public int BattleId { get; set; }
        public string Name { get; set; }


        //Relazioni molti a molti con il cavalieri
        public List<Knight> Knights { get; set; }= new List<Knight>();


    }
}

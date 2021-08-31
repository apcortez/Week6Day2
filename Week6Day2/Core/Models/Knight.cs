using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Day2.Core.Models
{
    public class Knight
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Relazione 1 a molti
        public List<Weapon> Weapons = new List<Weapon>();

        //Relazione molti a molti con la battaglia
        public List<Battle> Battles { get; set; } = new List<Battle>();

        //Relazione 1 a 1
        public Horse Horse { get; set; }
    }
}

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
        public string Description { get; set; }

        public List<Weapon> weapons { get; set; }
    }
}

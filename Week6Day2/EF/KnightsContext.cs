using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6Day2.Core.Models;

namespace Week6Day2.EF
{
    public class KnightsContext : DbContext
    {
        //Proprietà di tipo DbSet (una per ogni entità che voglio mappare sul db)
        public DbSet<Knight> Knights { get; set; } //la tabella sul db si chiamerà Knights
    }
}

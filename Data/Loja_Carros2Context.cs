using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Loja_Carros2.Models;

namespace Loja_Carros2.Data
{
    public class Loja_Carros2Context : DbContext
    {
        public Loja_Carros2Context (DbContextOptions<Loja_Carros2Context> options)
            : base(options)
        {
        }

        public DbSet<Loja_Carros2.Models.Carro> Carro { get; set; } = default!;

        public DbSet<Loja_Carros2.Models.Nota>? Nota { get; set; }

        public DbSet<Loja_Carros2.Models.Vendedor>? Vendedor { get; set; }

        public DbSet<Loja_Carros2.Models.Cliente>? Cliente { get; set; }
    }
}

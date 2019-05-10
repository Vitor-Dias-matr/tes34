using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SenacMs.Models;

    public class BancoContext : DbContext
    {
        public BancoContext (DbContextOptions<BancoContext> options)
            : base(options)
        {
        }

        public DbSet<SenacMs.Models.TipoProduto> TipoProduto { get; set; }

        public DbSet<SenacMs.Models.Marca> Marca { get; set; }

        public DbSet<SenacMs.Models.Produto> Produto { get; set; }
    }

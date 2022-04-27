using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Empresa.Models;

    public class EmpresaContext : DbContext
    {
        public EmpresaContext (DbContextOptions<EmpresaContext> options)
            : base(options)
        {
        }

        public DbSet<Empresa.Models.Funcionario> Funcionario { get; set; }
    }

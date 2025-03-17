using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiDanielLucas.Models;

namespace ApiDanielLucas.Data
{
    public class ApiDanielLucasContext : DbContext
    {
        public ApiDanielLucasContext (DbContextOptions<ApiDanielLucasContext> options)
            : base(options)
        {
        }

        public DbSet<ApiDanielLucas.Models.aluno> aluno { get; set; } = default!;
        public DbSet<ApiDanielLucas.Models.professor> professor { get; set; } = default!;
        public DbSet<ApiDanielLucas.Models.escola> escola { get; set; } = default!;
    }
}

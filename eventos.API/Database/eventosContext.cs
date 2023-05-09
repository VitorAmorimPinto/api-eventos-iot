using eventos.Models;
using Microsoft.EntityFrameworkCore;

namespace eventos.API.Database
{
    public class eventosContext : DbContext
    {
        public eventosContext(DbContextOptions<eventosContext> options): base(options) 
        { 
        
        }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Evento> Evento { get; set; }
    }
}

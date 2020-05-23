using Mica.Vocabulary.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Mica.Vocabulary.Entity
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Word> Words { get; set; }
    }
}

using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DB
{

    /* public class AppDbContext : DbContext
     {
         public DbSet<Usuario> Usuarios { get; set; }
        // public DbSet<Usuario> Roles { get; set; }

         public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
         {
         }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
         }
     }*/

    //public class AppDbContext : DbContext
    //{
    //    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    //}

    //public class AppDbContext : DbContext
    //{
    //    public DbSet<Usuario> Usuarios { get; set; }

    //    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    //    {
    //    }

    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    //    }

    //  //  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)  => optionsBuilder.UseNpgsql("Host=my_host;Database=my_db;Username=my_user;Password=my_pw");
    //}


    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // El connectionString debe venir de un archivo de configuraciones!
            optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=postgres");
            // .EnableSensitiveDataLogging(true);
            //           .UseLoggerFactory(new LoggerFactory().AddProvider( (category, level) => level == LogLevel.Information && category == DbLoggerCategory.Database.Command.Name, true));
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Agregamos una llave compuesta para tabla EstudiantesCursos
            modelBuilder.Entity<Usuario>().HasKey(x => new { x.id });

        }

        public DbSet<Usuario> usuario { get; set; }


        //[DbFunction(Schema = "dbo")]
        //public static int Cantidad_De_Cursos_Activos(int EstudianteId)
        //{
        //    throw new Exception();
        //}


    }


}

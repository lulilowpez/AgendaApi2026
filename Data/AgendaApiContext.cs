using AgendaApi.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace AgendaApi.Data
{
    public class AgendaApiContext : DbContext
    {
        //aca hirian las entidades para hacer las tablas en la base de datos
        public DbSet<User> Users { get; set; } //propiedad que representa la tabla de usuarios en la base de datos
        public DbSet<Contact> Contacts { get; set; } //propiedad que representa la tabla de contactos en la base de datos
        public AgendaApiContext(DbContextOptions<AgendaApiContext> options) : base(options) //constructor que recibe opciones de configuracion para la base de datos
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // datos de los contactos --> contact karen = new user(){datos del kare separados con ,};
            User Luli = new User()
            {
                Id = 1,
                Name = "Luli",
                Surname = "López",
                Password = "luli123",
                Email = "luli@example.com"
            };
            Contact MelodyC = new Contact()
            {
                Id = 1,
                Name = "Melody",
                Surname = "Contreras",
                Phone = 987654321,
                Email = "melody@example.com",
                Description = "Bebe",
                UserId = Luli.Id
            };
            Contact GuilleC = new Contact()
            {
                Id = 2,
                Name = "Guille",
                Surname = "Esteban",
                Phone = 123456789,
                Email = "guille@example.com"
                Description = "Bombón",
                UserId = Luli.Id
            };
            ///cargar datos;seeding modelBuilder.Entity<User>().HasData(karen;
            modelBuilder.Entity<User>().HasData(Luli);
            modelBuilder.Entity<Contact>().HasData(MelodyC, GuilleC);
            ///36.	Declarar luego las relaciones; claves foráneas. modelBuilder.Entity<Contact>(). HasMany<Group>().WithMany(c => c.Contacts); }
            modelBuilder.Entity<User>()
                .HasMany<Contact>(u => u.Contacts)
                .WithOne(c => c.User);
            modelBuilder.Entity<Contact>().
                HasOne<User>(c => c.User);
            base.OnModelCreating(modelBuilder); // ejecutar la configuración del modelo de la clase padre antes de agregar tus propias configuraciones.

        }
    }
}
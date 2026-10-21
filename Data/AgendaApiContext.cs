using AgendaApi.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace AgendaApi.Data
{
    public class AgendaApiContext : DbContext
    {
        //aca hirian las entidades para hacer las tablas en la base de datos
        public AgendaApiContext(DbContextOptions<AgendaApiContext> options) : base(options) //constructor que recibe opciones de configuracion para la base de datos
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // datos de los contactos del modo --> contact karen = new user(){datos del kare separados con ,};
            ///cargar datos;seeding modelBuilder.Entity<User>().HasData(karen;
            ///36.	Declarar luego las relaciones; claves foráneas. modelBuilder.Entity<Contact>(). HasMany<Group>().WithMany(c => c.Contacts); }
            ///            base.OnModelCreating(modelBuilder); // ejecutar la configuración del modelo de la clase padre antes de agregar tus propias configuraciones.
        }
    }
}
using CreacionesPajov.WEB.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace CreacionesPajov.WEB.Models.DAL
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var usuario = new Usuario
            {
                Id = "0h174cfb–4418–1c3e-a2bf-89f716w72cu3",
                Email = "felipecanorojascr7@gmail.com",
                NormalizedEmail = "FELIPECANOROJASCR7@GMAIL.COM",
                UserName = "felipecanorojascr7@gmail.com",
                NormalizedUserName = "FELIPECANOROJASCR7@GMAIL.COM",
                Estado = true
            };
            //encriptamos el password
            PasswordHasher<Usuario> ph = new();
            usuario.PasswordHash = ph.HashPassword(usuario, "creacionespajov123");
            //guardamos el usuario

            modelBuilder.Entity<Usuario>().HasData(usuario);

            modelBuilder.Entity<TipoDocumento>().HasData(
                new TipoDocumento
                {
                    TipoDocumentoId = 1,
                    Nombre = "CC"
                },
                new TipoDocumento
                {
                    TipoDocumentoId = 2,
                    Nombre = "CE"
                }

                );


            modelBuilder.Entity<TipoOperacion>().HasData(
                new TipoOperacion
                {
                    TipoOperacionId = 1,
                    Nombre = "BASE"
                },
                new TipoOperacion
                {
                    TipoOperacionId = 2,
                    Nombre = "MODA"
                }

                );
            
            
            modelBuilder.Entity<Empleado>().HasData(
             new Empleado
             {
                 EmpleadoId = 1,
                 Documento = "986547",
                 TipoDocumentoId = 1,
                 Nombre = "Sara",
                 Apellido = "Guzman",
                 Edad = 20,
                 Email = "Sarareina@gmail.com",
                 Telefono = 4560536,
                 Cargo = "C.E.O",
                 FechaRegistro = new DateTime(2017, 2, 10),
                 Estado = true
             }
             );
           



        }

    }
}

  
            





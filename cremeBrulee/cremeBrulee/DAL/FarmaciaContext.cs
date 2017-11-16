﻿using cremeBrulee.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace cremeBrulee.DAL
{
    public class FarmaciaContext : DbContext
    {
        public FarmaciaContext() : base("FarmaciaContext")
        {

        }

        public DbSet<Carrito> Carrito { get; set; }
        public DbSet<Cuenta> Cuenta { get; set; }
        public DbSet<Direccion> Direccion { get; set; }
        public DbSet<Inventario> Inventario { get; set; }
        public DbSet<Orden> Orden { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
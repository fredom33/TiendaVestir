﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ENTIDAD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class tienda_vestirEntities : DbContext
    {
        public tienda_vestirEntities()
            : base("name=tienda_vestirEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<detalle_factura> detalle_factura { get; set; }
        public virtual DbSet<factura> factura { get; set; }
        public virtual DbSet<producto> producto { get; set; }
        public virtual DbSet<tipo_producto> tipo_producto { get; set; }
    }
}
﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace QP_Comercio_Electronico.Models
{
    public partial class JosephTutos_PedidosContext : DbContext
    {

        public JosephTutos_PedidosContext(DbContextOptions<JosephTutos_PedidosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categorium> Categoria { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Mediopago> Mediopagos { get; set; }
        public virtual DbSet<Ordendetalle> Ordendetalles { get; set; }
        public virtual DbSet<Ordene> Ordenes { get; set; }
        public virtual DbSet<Tiendum> Tienda { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorium>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("categoria");

                entity.Property(e => e.CantId)
                    .HasMaxLength(10)
                    .HasColumnName("cant_id")
                    .IsFixedLength(true);

                entity.Property(e => e.CatDescripcion)
                    .HasMaxLength(10)
                    .HasColumnName("cat_descripcion")
                    .IsFixedLength(true);

                entity.Property(e => e.CatIdestado)
                    .HasMaxLength(10)
                    .HasColumnName("cat_idestado")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(x => x.ClieId);

                entity.ToTable("cliente");

                entity.Property(e => e.ClieId)
                    .ValueGeneratedNever()
                    .HasColumnName("clie_id");

                entity.Property(e => e.ClieAltura)
                    .HasMaxLength(50)
                    .HasColumnName("clie_altura");

                entity.Property(e => e.ClieApellidos)
                    .HasMaxLength(50)
                    .HasColumnName("clie_apellidos");

                entity.Property(e => e.ClieBarrio)
                    .HasMaxLength(50)
                    .HasColumnName("clie_barrio");

                entity.Property(e => e.ClieDireccion)
                    .HasMaxLength(50)
                    .HasColumnName("clie_direccion");

                entity.Property(e => e.ClieIdentificacion)
                    .HasMaxLength(10)
                    .HasColumnName("clie_identificacion");

                entity.Property(e => e.ClieIdsexo)
                    .HasMaxLength(50)
                    .HasColumnName("clie_idsexo");

                entity.Property(e => e.ClieIdtipoidentificacion)
                    .HasMaxLength(50)
                    .HasColumnName("clie_idtipoidentificacion");

                entity.Property(e => e.ClieLatitud)
                    .HasMaxLength(50)
                    .HasColumnName("clie_latitud");

                entity.Property(e => e.ClieLongitud)
                    .HasMaxLength(50)
                    .HasColumnName("clie_longitud");

                entity.Property(e => e.ClieNombre)
                    .HasMaxLength(50)
                    .HasColumnName("clie_nombre");

                entity.Property(e => e.ClieTelefono)
                    .HasMaxLength(50)
                    .HasColumnName("clie_telefono");
            });

            modelBuilder.Entity<Mediopago>(entity =>
            {
                entity.HasKey(x => x.MepId);

                entity.ToTable("mediopago");

                entity.Property(e => e.MepId)
                    .ValueGeneratedNever()
                    .HasColumnName("Mep_id");

                entity.Property(e => e.MepDescripcion)
                    .HasMaxLength(50)
                    .HasColumnName("mep_descripcion");
            });

            modelBuilder.Entity<Ordendetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ordendetalle");

                entity.Property(e => e.DetordCantidad)
                    .HasMaxLength(50)
                    .HasColumnName("detord_cantidad");

                entity.Property(e => e.DetordColor)
                    .HasMaxLength(50)
                    .HasColumnName("detord_color");

                entity.Property(e => e.DetordDescuento)
                    .HasMaxLength(50)
                    .HasColumnName("detord_descuento");

                entity.Property(e => e.DetordFechaenvio)
                    .HasMaxLength(50)
                    .HasColumnName("detord_fechaenvio");

                entity.Property(e => e.DetordId).HasColumnName("detord_id");

                entity.Property(e => e.DetordIdproducto)
                    .HasMaxLength(50)
                    .HasColumnName("detord_idproducto");

                entity.Property(e => e.DetordOrdennumero)
                    .HasMaxLength(50)
                    .HasColumnName("detord_ordennumero");

                entity.Property(e => e.DetordPrecio)
                    .HasMaxLength(50)
                    .HasColumnName("detord_precio");

                entity.Property(e => e.DetordTamano)
                    .HasMaxLength(50)
                    .HasColumnName("detord_tamano");

                entity.Property(e => e.DetordTotal)
                    .HasMaxLength(50)
                    .HasColumnName("detord_total");
            });

            modelBuilder.Entity<Ordene>(entity =>
            {
                entity.HasKey(x => x.OrdId);

                entity.ToTable("ordenes");

                entity.Property(e => e.OrdId)
                    .ValueGeneratedNever()
                    .HasColumnName("ord_id");

                entity.Property(e => e.OrdAltura)
                    .HasMaxLength(50)
                    .HasColumnName("ord_altura");

                entity.Property(e => e.OrdDireccion)
                    .HasMaxLength(50)
                    .HasColumnName("ord_direccion");

                entity.Property(e => e.OrdFecha)
                    .HasMaxLength(50)
                    .HasColumnName("ord_fecha");

                entity.Property(e => e.OrdFechaenvio)
                    .HasMaxLength(50)
                    .HasColumnName("ord_fechaenvio");

                entity.Property(e => e.OrdIdcliente)
                    .HasMaxLength(50)
                    .HasColumnName("ord_idcliente");

                entity.Property(e => e.OrdLatitud)
                    .HasMaxLength(50)
                    .HasColumnName("ord_latitud");

                entity.Property(e => e.OrdLongitud)
                    .HasMaxLength(50)
                    .HasColumnName("ord_longitud");

                entity.Property(e => e.OrdNumero)
                    .HasMaxLength(50)
                    .HasColumnName("ord_numero");
            });

            modelBuilder.Entity<Tiendum>(entity =>
            {
                entity.HasKey(x => x.TienId);

                entity.ToTable("tienda");

                entity.Property(e => e.TienId).HasColumnName("tien_id");

                entity.Property(e => e.TienAltura)
                    .HasMaxLength(50)
                    .HasColumnName("tien_altura");

                entity.Property(e => e.TienBarrio)
                    .HasMaxLength(50)
                    .HasColumnName("tien_barrio");

                entity.Property(e => e.TienCorreo)
                    .HasMaxLength(50)
                    .HasColumnName("tien_correo");

                entity.Property(e => e.TienDireccion)
                    .HasMaxLength(50)
                    .HasColumnName("tien_direccion");

                entity.Property(e => e.TienLatitud)
                    .HasMaxLength(50)
                    .HasColumnName("tien_latitud");

                entity.Property(e => e.TienLongitud)
                    .HasMaxLength(50)
                    .HasColumnName("tien_longitud");

                entity.Property(e => e.TienNit)
                    .HasMaxLength(50)
                    .HasColumnName("tien_nit");

                entity.Property(e => e.TienRazonsocial)
                    .HasMaxLength(200)
                    .HasColumnName("tien_razonsocial");

                entity.Property(e => e.TienTelefono)
                    .HasMaxLength(50)
                    .HasColumnName("tien_telefono");

                entity.Property(e => e.TienTipoidentificacion)
                    .HasMaxLength(50)
                    .HasColumnName("tien_tipoidentificacion");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
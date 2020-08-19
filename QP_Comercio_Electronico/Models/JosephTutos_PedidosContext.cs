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


        public virtual DbSet<Banco> Bancos { get; set; }
        public virtual DbSet<Categorium> Categoria { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Cuentascliente> Cuentasclientes { get; set; }
        public virtual DbSet<Detalletiendacategorium> Detalletiendacategoria { get; set; }
        public virtual DbSet<Estadoorden> Estadoordens { get; set; }
        public virtual DbSet<Mediopago> Mediopagos { get; set; }
        public virtual DbSet<Ordendetalle> Ordendetalles { get; set; }
        public virtual DbSet<Ordene> Ordenes { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Subcategorium> Subcategoria { get; set; }
        public virtual DbSet<Tiendum> Tienda { get; set; }
        public virtual DbSet<Tipocuentum> Tipocuenta { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Banco>(entity =>
            {
                entity.HasKey(x => x.BanId);

                entity.ToTable("bancos");

                entity.Property(e => e.BanId)
                    .ValueGeneratedNever()
                    .HasColumnName("ban_id");

                entity.Property(e => e.BanDescripcion).HasColumnName("ban_descripcion");
            });

            modelBuilder.Entity<Categorium>(entity =>
            {
                entity.HasKey(x => x.CantId);

                entity.ToTable("categoria");

                entity.Property(e => e.CantId).HasColumnName("cant_id");

                entity.Property(e => e.CatDescripcion)
                    .HasMaxLength(50)
                    .HasColumnName("cat_descripcion");

                entity.Property(e => e.CatFoto).HasColumnName("cat_foto");

                entity.Property(e => e.CatIdestado)
                    .HasMaxLength(10)
                    .HasColumnName("cat_idestado")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(x => x.ClieId);

                entity.ToTable("cliente");

                entity.Property(e => e.ClieId).HasColumnName("clie_id");

                entity.Property(e => e.ClieAltura)
                    .HasMaxLength(50)
                    .HasColumnName("clie_altura");

                entity.Property(e => e.ClieApellidos)
                    .HasMaxLength(50)
                    .HasColumnName("clie_apellidos");

                entity.Property(e => e.ClieBarrio)
                    .HasMaxLength(50)
                    .HasColumnName("clie_barrio");

                entity.Property(e => e.ClieClave)
                    .HasMaxLength(50)
                    .HasColumnName("clie_clave");

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

            modelBuilder.Entity<Cuentascliente>(entity =>
            {
                entity.HasKey(x => x.MiscId);

                entity.ToTable("cuentascliente");

                entity.Property(e => e.MiscId)
                    .ValueGeneratedNever()
                    .HasColumnName("misc_id");

                entity.Property(e => e.MiscIdbanco).HasColumnName("misc_idbanco");

                entity.Property(e => e.MiscIdcliente).HasColumnName("misc_idcliente");

                entity.Property(e => e.MiscIdtipocuenta).HasColumnName("misc_idtipocuenta");

                entity.HasOne(d => d.MiscIdbancoNavigation)
                    .WithMany(p => p.Cuentasclientes)
                    .HasForeignKey(x => x.MiscIdbanco)
                    .HasConstraintName("FK_cuentascliente_bancos");

                entity.HasOne(d => d.MiscIdclienteNavigation)
                    .WithMany(p => p.Cuentasclientes)
                    .HasForeignKey(x => x.MiscIdcliente)
                    .HasConstraintName("FK_cuentascliente_cliente");

                entity.HasOne(d => d.MiscIdtipocuentaNavigation)
                    .WithMany(p => p.Cuentasclientes)
                    .HasForeignKey(x => x.MiscIdtipocuenta)
                    .HasConstraintName("FK_cuentascliente_tipocuenta");
            });

            modelBuilder.Entity<Detalletiendacategorium>(entity =>
            {
                entity.HasKey(x => new { x.CanttienIdtienda, x.CanttienIdcategoria });

                entity.ToTable("detalletiendacategoria");

                entity.Property(e => e.CanttienIdtienda).HasColumnName("canttien_idtienda");

                entity.Property(e => e.CanttienIdcategoria).HasColumnName("canttien_idcategoria");

                entity.HasOne(d => d.CanttienIdcategoriaNavigation)
                    .WithMany(p => p.Detalletiendacategoria)
                    .HasForeignKey(x => x.CanttienIdcategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_detalletiendacategoria_categoria");

                entity.HasOne(d => d.CanttienIdtiendaNavigation)
                    .WithMany(p => p.Detalletiendacategoria)
                    .HasForeignKey(x => x.CanttienIdtienda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_detalletiendacategoria_tienda");
            });

            modelBuilder.Entity<Estadoorden>(entity =>
            {
                entity.HasKey(x => x.EsorId);

                entity.ToTable("estadoorden");

                entity.Property(e => e.EsorId).HasColumnName("esor_id");

                entity.Property(e => e.EsorIdDescripcion)
                    .HasMaxLength(50)
                    .HasColumnName("esor_id_descripcion");
            });

            modelBuilder.Entity<Mediopago>(entity =>
            {
                entity.HasKey(x => x.MepId);

                entity.ToTable("mediopago");

                entity.Property(e => e.MepId).HasColumnName("Mep_id");

                entity.Property(e => e.MepDescripcion)
                    .HasMaxLength(50)
                    .HasColumnName("mep_descripcion");

                entity.Property(e => e.MepDetalle).HasColumnName("mep_detalle");

                entity.Property(e => e.MepFoto).HasColumnName("mep_foto");
            });

            modelBuilder.Entity<Ordendetalle>(entity =>
            {
                entity.HasKey(x => x.DetordId);

                entity.ToTable("ordendetalle");

                entity.Property(e => e.DetordId).HasColumnName("detord_id");

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

                entity.Property(e => e.DetordIdproducto).HasColumnName("detord_idproducto");

                entity.Property(e => e.DetordOrdennumero).HasColumnName("detord_ordennumero");

                entity.Property(e => e.DetordPrecio)
                    .HasMaxLength(50)
                    .HasColumnName("detord_precio");

                entity.Property(e => e.DetordTamano)
                    .HasMaxLength(50)
                    .HasColumnName("detord_tamano");

                entity.Property(e => e.DetordTotal)
                    .HasMaxLength(50)
                    .HasColumnName("detord_total");

                entity.HasOne(d => d.DetordIdproductoNavigation)
                    .WithMany(p => p.Ordendetalles)
                    .HasForeignKey(x => x.DetordIdproducto)
                    .HasConstraintName("FK_ordendetalle_producto");

                entity.HasOne(d => d.DetordOrdennumeroNavigation)
                    .WithMany(p => p.Ordendetalles)
                    .HasForeignKey(x => x.DetordOrdennumero)
                    .HasConstraintName("FK_ordendetalle_ordenes");
            });

            modelBuilder.Entity<Ordene>(entity =>
            {
                entity.HasKey(x => x.OrdId);

                entity.ToTable("ordenes");

                entity.Property(e => e.OrdId).HasColumnName("ord_id");

                entity.Property(e => e.OrdAltura)
                    .HasMaxLength(50)
                    .HasColumnName("ord_altura");

                entity.Property(e => e.OrdDescripcion)
                    .HasMaxLength(50)
                    .HasColumnName("ord_descripcion");

                entity.Property(e => e.OrdDireccion)
                    .HasMaxLength(50)
                    .HasColumnName("ord_direccion");

                entity.Property(e => e.OrdFecha)
                    .HasMaxLength(50)
                    .HasColumnName("ord_fecha");

                entity.Property(e => e.OrdFechaenvio)
                    .HasMaxLength(50)
                    .HasColumnName("ord_fechaenvio");

                entity.Property(e => e.OrdIdcliente).HasColumnName("ord_idcliente");

                entity.Property(e => e.OrdIdestado).HasColumnName("ord_idestado");

                entity.Property(e => e.OrdIdformapago).HasColumnName("ord_idformapago");

                entity.Property(e => e.OrdIdtienda).HasColumnName("ord_idtienda");

                entity.Property(e => e.OrdLatitud)
                    .HasMaxLength(50)
                    .HasColumnName("ord_latitud");

                entity.Property(e => e.OrdLongitud)
                    .HasMaxLength(50)
                    .HasColumnName("ord_longitud");

                entity.Property(e => e.OrdNumero)
                    .HasMaxLength(50)
                    .HasColumnName("ord_numero");

                entity.Property(e => e.OrdPagacon)
                    .HasMaxLength(50)
                    .HasColumnName("ord_pagacon");

                entity.Property(e => e.OrdTelefono)
                    .HasMaxLength(50)
                    .HasColumnName("ord_telefono");

                entity.Property(e => e.OrdTotalcompra).HasColumnName("ord_totalcompra");

                entity.HasOne(d => d.OrdIdclienteNavigation)
                    .WithMany(p => p.Ordenes)
                    .HasForeignKey(x => x.OrdIdcliente)
                    .HasConstraintName("FK_ordenes_cliente");

                entity.HasOne(d => d.OrdIdestadoNavigation)
                    .WithMany(p => p.Ordenes)
                    .HasForeignKey(x => x.OrdIdestado)
                    .HasConstraintName("FK_ordenes_estadoorden");

                entity.HasOne(d => d.OrdIdformapagoNavigation)
                    .WithMany(p => p.Ordenes)
                    .HasForeignKey(x => x.OrdIdformapago)
                    .HasConstraintName("FK_ordenes_mediopago");

                entity.HasOne(d => d.OrdIdtiendaNavigation)
                    .WithMany(p => p.Ordenes)
                    .HasForeignKey(x => x.OrdIdtienda)
                    .HasConstraintName("FK_ordenes_tienda");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(x => x.ProdId);

                entity.ToTable("producto");

                entity.Property(e => e.ProdId).HasColumnName("prod_id");

                entity.Property(e => e.ProdCalificacion).HasColumnName("prod_calificacion");

                entity.Property(e => e.ProdCodigo)
                    .HasMaxLength(50)
                    .HasColumnName("prod_codigo");

                entity.Property(e => e.ProdColor)
                    .HasMaxLength(50)
                    .HasColumnName("prod_color");

                entity.Property(e => e.ProdCountventas)
                    .HasMaxLength(50)
                    .HasColumnName("prod_countventas");

                entity.Property(e => e.ProdDescripcion)
                    .HasMaxLength(50)
                    .HasColumnName("prod_descripcion");

                entity.Property(e => e.ProdDescuento).HasColumnName("prod_descuento");

                entity.Property(e => e.ProdFavorito).HasColumnName("prod_favorito");

                entity.Property(e => e.ProdFecha)
                    .HasMaxLength(50)
                    .HasColumnName("prod_fecha");

                entity.Property(e => e.ProdFoto).HasColumnName("prod_foto");

                entity.Property(e => e.ProdIdcategoria).HasColumnName("prod_idcategoria");

                entity.Property(e => e.ProdIdtienda).HasColumnName("prod_idtienda");

                entity.Property(e => e.ProdNombre)
                    .HasMaxLength(50)
                    .HasColumnName("prod_nombre");

                entity.Property(e => e.ProdPrecioanterior).HasColumnName("prod_precioanterior");

                entity.Property(e => e.ProdPreciounitario).HasColumnName("prod_preciounitario");

                entity.Property(e => e.ProdRanking)
                    .HasMaxLength(50)
                    .HasColumnName("prod_ranking");

                entity.Property(e => e.ProdStockmin).HasColumnName("prod_stockmin");

                entity.Property(e => e.ProdStok).HasColumnName("prod_stok");

                entity.Property(e => e.ProdStokmax).HasColumnName("prod_stokmax");

                entity.HasOne(d => d.ProdIdcategoriaNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(x => x.ProdIdcategoria)
                    .HasConstraintName("FK_producto_subcategoria");

                entity.HasOne(d => d.ProdIdtiendaNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(x => x.ProdIdtienda)
                    .HasConstraintName("FK_producto_tienda");
            });

            modelBuilder.Entity<Subcategorium>(entity =>
            {
                entity.HasKey(x => x.SubcatId);

                entity.ToTable("subcategoria");

                entity.Property(e => e.SubcatId)
                    .ValueGeneratedNever()
                    .HasColumnName("subcat_id");

                entity.Property(e => e.SubcatDescripcion)
                    .HasMaxLength(50)
                    .HasColumnName("subcat_descripcion");

                entity.Property(e => e.SubcatFoto).HasColumnName("subcat_foto");

                entity.Property(e => e.SubcatIdcategoria).HasColumnName("subcat_idcategoria");

                entity.HasOne(d => d.SubcatIdcategoriaNavigation)
                    .WithMany(p => p.Subcategoria)
                    .HasForeignKey(x => x.SubcatIdcategoria)
                    .HasConstraintName("FK_subcategoria_categoria");
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

                entity.Property(e => e.TienClave)
                    .HasMaxLength(50)
                    .HasColumnName("tien_clave");

                entity.Property(e => e.TienCorreo)
                    .HasMaxLength(50)
                    .HasColumnName("tien_correo");

                entity.Property(e => e.TienDireccion)
                    .HasMaxLength(50)
                    .HasColumnName("tien_direccion");

                entity.Property(e => e.TienFacebook)
                    .HasMaxLength(100)
                    .HasColumnName("tien_facebook");

                entity.Property(e => e.TienFoto).HasColumnName("tien_foto");

                entity.Property(e => e.TienIdcliente)
                    .HasMaxLength(50)
                    .HasColumnName("tien_idcliente");

                entity.Property(e => e.TienInstagram)
                    .HasMaxLength(100)
                    .HasColumnName("tien_instagram");

                entity.Property(e => e.TienKey)
                    .HasMaxLength(50)
                    .HasColumnName("tien_key");

                entity.Property(e => e.TienLatitud)
                    .HasMaxLength(50)
                    .HasColumnName("tien_latitud");

                entity.Property(e => e.TienLongitud)
                    .HasMaxLength(50)
                    .HasColumnName("tien_longitud");

                entity.Property(e => e.TienNit)
                    .HasMaxLength(50)
                    .HasColumnName("tien_nit");

                entity.Property(e => e.TienPkey)
                    .HasMaxLength(50)
                    .HasColumnName("tien_pkey");

                entity.Property(e => e.TienPremium).HasColumnName("tien_premium");

                entity.Property(e => e.TienPrivatekey)
                    .HasMaxLength(50)
                    .HasColumnName("tien_privatekey");

                entity.Property(e => e.TienRazonsocial)
                    .HasMaxLength(200)
                    .HasColumnName("tien_razonsocial");

                entity.Property(e => e.TienTelefono)
                    .HasMaxLength(50)
                    .HasColumnName("tien_telefono");

                entity.Property(e => e.TienTipoidentificacion)
                    .HasMaxLength(50)
                    .HasColumnName("tien_tipoidentificacion");

                entity.Property(e => e.TienTwitter)
                    .HasMaxLength(100)
                    .HasColumnName("tien_twitter");

                entity.Property(e => e.TienWhatsapp)
                    .HasMaxLength(100)
                    .HasColumnName("tien_whatsapp");

                entity.Property(e => e.TienYoutube)
                    .HasMaxLength(100)
                    .HasColumnName("tien_youtube");
            });

            modelBuilder.Entity<Tipocuentum>(entity =>
            {
                entity.HasKey(x => x.TipcuId);

                entity.ToTable("tipocuenta");

                entity.Property(e => e.TipcuId)
                    .ValueGeneratedNever()
                    .HasColumnName("tipcu_id");

                entity.Property(e => e.TipcuDescripcion).HasColumnName("tipcu_descripcion");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

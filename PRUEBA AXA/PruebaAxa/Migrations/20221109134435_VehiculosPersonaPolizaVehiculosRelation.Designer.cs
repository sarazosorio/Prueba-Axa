﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PruebaAxa.Data;

#nullable disable

namespace PruebaAxa.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221109134435_VehiculosPersonaPolizaVehiculosRelation")]
    partial class VehiculosPersonaPolizaVehiculosRelation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PruebaAxa.Models.Ciudad", b =>
                {
                    b.Property<int>("idCiudad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idCiudad");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idCiudad"));

                    b.Property<string>("nombreCiudad")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("nombreCiudad");

                    b.HasKey("idCiudad");

                    b.ToTable("Ciudades");
                });

            modelBuilder.Entity("PruebaAxa.Models.DatosCliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idCliente");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"));

                    b.Property<byte[]>("fechaGrabacion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion")
                        .HasColumnName("fechaGrabacion");

                    b.Property<string>("identificacionCliente")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("identificacionCliente");

                    b.Property<string>("numeroTelefono")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("numeroTelefono");

                    b.Property<string>("primerApellido")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("primerApellido");

                    b.Property<string>("primerNombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("primerNombre");

                    b.Property<string>("segundoApellido")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("segundoApellido");

                    b.Property<string>("segundoNombre")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("segundoNombre");

                    b.Property<string>("tipoDocumento")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)")
                        .HasColumnName("tipoDocumento");

                    b.HasKey("IdCliente");

                    b.ToTable("DatosClientes");
                });

            modelBuilder.Entity("PruebaAxa.Models.PolizaVehiculos", b =>
                {
                    b.Property<int>("idPoliza")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idPoliza");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idPoliza"));

                    b.Property<int?>("VehiculosPersonaidVehiculo")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaExpedicion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fechaExpedicion");

                    b.Property<DateTime>("fechaFin")
                        .HasColumnType("datetime2")
                        .HasColumnName("fechaFin");

                    b.Property<byte[]>("fechaGrabacion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion")
                        .HasColumnName("fechaGrabacion");

                    b.Property<DateTime>("fechaInicio")
                        .HasColumnType("datetime2")
                        .HasColumnName("fechaInicio");

                    b.Property<DateTime>("fechaVencimiento")
                        .HasColumnType("datetime2")
                        .HasColumnName("fechaVencimiento");

                    b.Property<int>("idVehiculo")
                        .HasColumnType("int")
                        .HasColumnName("idVehiculo");

                    b.HasKey("idPoliza");

                    b.HasIndex("VehiculosPersonaidVehiculo");

                    b.ToTable("PolizaVehiculos");
                });

            modelBuilder.Entity("PruebaAxa.Models.VehiculosPersona", b =>
                {
                    b.Property<int>("idVehiculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idVehiculo");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idVehiculo"));

                    b.Property<int?>("DatosClienteIdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("IdCliente");

                    b.Property<string>("colorVehiculo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("colorVehiculo");

                    b.Property<byte[]>("fechaGrabacion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion")
                        .HasColumnName("fechaGrabacion");

                    b.Property<string>("marcaVehiculo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("marcaVehiculo");

                    b.Property<string>("modeloVehiculo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("modeloVehiculo");

                    b.Property<string>("placaVehiculo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("placaVehiculo");

                    b.Property<string>("serialMotor")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("serialMotor");

                    b.Property<string>("tipoServicio")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("tipoServicio");

                    b.HasKey("idVehiculo");

                    b.HasIndex("DatosClienteIdCliente");

                    b.ToTable("VehiculosPersonas");
                });

            modelBuilder.Entity("PruebaAxa.Models.PolizaVehiculos", b =>
                {
                    b.HasOne("PruebaAxa.Models.VehiculosPersona", "VehiculosPersona")
                        .WithMany("PolizaVehiculos")
                        .HasForeignKey("VehiculosPersonaidVehiculo");

                    b.Navigation("VehiculosPersona");
                });

            modelBuilder.Entity("PruebaAxa.Models.VehiculosPersona", b =>
                {
                    b.HasOne("PruebaAxa.Models.DatosCliente", "DatosCliente")
                        .WithMany("VehiculosPersona")
                        .HasForeignKey("DatosClienteIdCliente");

                    b.Navigation("DatosCliente");
                });

            modelBuilder.Entity("PruebaAxa.Models.DatosCliente", b =>
                {
                    b.Navigation("VehiculosPersona");
                });

            modelBuilder.Entity("PruebaAxa.Models.VehiculosPersona", b =>
                {
                    b.Navigation("PolizaVehiculos");
                });
#pragma warning restore 612, 618
        }
    }
}

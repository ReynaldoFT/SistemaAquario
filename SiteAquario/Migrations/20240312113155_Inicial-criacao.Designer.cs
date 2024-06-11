﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SiteAquario.Data;
using SiteAquario.Models;

#nullable disable

namespace SiteAquario.Migrations
{
    [DbContext(typeof(SiteAquarioContext))]
    [Migration("20240312113155_Inicial-criacao")]
    partial class Inicialcriacao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SiteAquario.Models.ValoresSensor", b =>
                {
                    b.Property<int>("ValoresSensorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ValoresSensorID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ValoresSensorID"), 1L, 1);

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataCadastro");

                    b.Property<double>("Ph")
                        .HasColumnType("float")
                        .HasColumnName("Ph");

                    b.Property<double>("Temperatura")
                        .HasColumnType("float")
                        .HasColumnName("Temperatura");

                    b.HasKey("ValoresSensorID");

                    b.ToTable("ValoresSensor");
                });
#pragma warning restore 612, 618
        }
    }
}
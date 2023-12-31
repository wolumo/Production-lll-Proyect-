﻿// <auto-generated />
using System;
using Aggregate_Planing.Conexion;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Aggregate_Planing.Migrations
{
    [DbContext(typeof(MyDBContexrt))]
    [Migration("20230616174847_ForeignKeysFinal")]
    partial class ForeignKeysFinal
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Aggregate_Planing.Model.AgreggationDetail", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("idMonth")
                        .HasColumnType("int");

                    b.Property<int>("idPlan")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("AgreggationDetails");
                });

            modelBuilder.Entity("Aggregate_Planing.Model.AgreggationPlan", b =>
                {
                    b.Property<int>("idPlan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idPlan"));

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("NamePlan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idPlan");

                    b.ToTable("AgreggationPlans");
                });

            modelBuilder.Entity("Aggregate_Planing.Model.Month", b =>
                {
                    b.Property<int>("idMonth")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idMonth"));

                    b.Property<string>("MonthName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idMonth");

                    b.ToTable("Months");
                });
#pragma warning restore 612, 618
        }
    }
}

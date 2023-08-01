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
    [Migration("20230801232635_DetailCostForeignKey")]
    partial class DetailCostForeignKey
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Aggregate_Planing.Model.AgregationDetailCost", b =>
                {
                    b.Property<int>("AgregationDetailCostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AgregationDetailCostId"));

                    b.Property<double>("costForShortages")
                        .HasColumnType("float");

                    b.Property<double>("costToHires")
                        .HasColumnType("float");

                    b.Property<double>("costToLabour")
                        .HasColumnType("float");

                    b.Property<double>("costToStore")
                        .HasColumnType("float");

                    b.Property<double>("costTolayingOff")
                        .HasColumnType("float");

                    b.Property<int>("idMonth")
                        .HasColumnType("int");

                    b.Property<int>("idPlan")
                        .HasColumnType("int");

                    b.HasKey("AgregationDetailCostId");

                    b.ToTable("AgreggationDetailsCosts");
                });

            modelBuilder.Entity("Aggregate_Planing.Model.AgreggationDetail", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("Demand")
                        .HasColumnType("int");

                    b.Property<int>("RequiredOperators")
                        .HasColumnType("int");

                    b.Property<int>("UnitPerOperador")
                        .HasColumnType("int");

                    b.Property<int>("actualOperators")
                        .HasColumnType("int");

                    b.Property<int>("businessDays")
                        .HasColumnType("int");

                    b.Property<int>("idMonth")
                        .HasColumnType("int");

                    b.Property<int>("idPlan")
                        .HasColumnType("int");

                    b.Property<int>("inventory")
                        .HasColumnType("int");

                    b.Property<int>("missingUnits")
                        .HasColumnType("int");

                    b.Property<int>("operatorsOff")
                        .HasColumnType("int");

                    b.Property<int>("operatorsUsed")
                        .HasColumnType("int");

                    b.Property<int>("opertorsHired")
                        .HasColumnType("int");

                    b.Property<int>("unitsAvailable")
                        .HasColumnType("int");

                    b.Property<int>("unitsProduced")
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

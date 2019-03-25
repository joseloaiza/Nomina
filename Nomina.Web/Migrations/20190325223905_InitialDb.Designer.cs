﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nomina.Web.Data;

namespace Nomina.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190325223905_InitialDb")]
    partial class InitialDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Nomina.Web.Data.Entities.Empleoye", b =>
                {
                    b.Property<string>("NumDoc")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AdmissionDate");

                    b.Property<DateTime>("BirthDate");

                    b.Property<int>("DocumentType");

                    b.Property<string>("FirstLastName");

                    b.Property<string>("FirstName");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Mail");

                    b.Property<DateTime>("RetirementDate");

                    b.Property<double>("Salary");

                    b.Property<string>("SecondLastName");

                    b.Property<string>("SecondName");

                    b.HasKey("NumDoc");

                    b.ToTable("Empleoyes");
                });
#pragma warning restore 612, 618
        }
    }
}

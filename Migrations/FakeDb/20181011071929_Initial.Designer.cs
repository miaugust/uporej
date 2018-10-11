﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rejupo.Models;

namespace Rejupo.Migrations.FakeDb
{
    [DbContext(typeof(FakeDbContext))]
    [Migration("20181011071929_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-preview2-35157");

            modelBuilder.Entity("Rejupo.Models.Division", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Abbreviation")
                        .IsRequired();

                    b.Property<string>("Descritption");

                    b.HasKey("Id");

                    b.ToTable("Divisions");
                });
#pragma warning restore 612, 618
        }
    }
}
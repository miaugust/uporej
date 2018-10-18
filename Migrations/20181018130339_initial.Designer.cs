﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rejupo.Models;

namespace Rejupo.Migrations
{
    [DbContext(typeof(FakeDbContext))]
    [Migration("20181018130339_initial")]
    partial class initial
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

            modelBuilder.Entity("Rejupo.Models.Docs.AuthorizationScope", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Scope");

                    b.HasKey("Id");

                    b.ToTable("AuthorizationScopes");
                });

            modelBuilder.Entity("Rejupo.Models.Docs.Document_Scope", b =>
                {
                    b.Property<int>("DocumentBaseId");

                    b.Property<int>("AuthorizationScopeId");

                    b.HasKey("DocumentBaseId", "AuthorizationScopeId");

                    b.HasIndex("AuthorizationScopeId");

                    b.ToTable("Document_Scopes");
                });

            modelBuilder.Entity("Rejupo.Models.Docs.DocumentBase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CancelingDate");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Name");

                    b.Property<string>("OwnerId");

                    b.Property<DateTime?>("ValidTo");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId")
                        .IsUnique();

                    b.ToTable("DocumentBases");
                });

            modelBuilder.Entity("Rejupo.Models.Employee", b =>
                {
                    b.Property<string>("ControlNumber")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Division")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Pos_title");

                    b.HasKey("ControlNumber");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Rejupo.Models.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("Rejupo.Models.Docs.Document_Scope", b =>
                {
                    b.HasOne("Rejupo.Models.Docs.AuthorizationScope", "AuthorizationScope")
                        .WithMany()
                        .HasForeignKey("AuthorizationScopeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Rejupo.Models.Docs.DocumentBase", "DocumentBase")
                        .WithMany()
                        .HasForeignKey("DocumentBaseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Rejupo.Models.Docs.DocumentBase", b =>
                {
                    b.HasOne("Rejupo.Models.Employee", "Owner")
                        .WithOne("Document")
                        .HasForeignKey("Rejupo.Models.Docs.DocumentBase", "OwnerId");
                });
#pragma warning restore 612, 618
        }
    }
}

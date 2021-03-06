﻿// <auto-generated />
using System;
using ChildhoodVaccination.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ChildhoodVaccination.Migrations
{
    [DbContext(typeof(ChildhoodVaccinationDbContext))]
    partial class ChildhoodVaccinationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ChildhoodVaccination.Models.Child", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDate");

                    b.Property<DateTime>("Created");

                    b.Property<string>("ID_doctor");

                    b.Property<string>("ID_hospital");

                    b.Property<string>("ID_schedule");

                    b.Property<string>("IIN");

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.Property<string>("Paternity");

                    b.Property<string>("Phone");

                    b.Property<byte[]>("Photo");

                    b.Property<DateTime>("Updated");

                    b.HasKey("ID");

                    b.ToTable("Children");
                });
#pragma warning restore 612, 618
        }
    }
}

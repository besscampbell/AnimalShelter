﻿// <auto-generated />
using System;
using APIAnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APIAnimalShelter.Migrations
{
    [DbContext(typeof(APIAnimalShelterContext))]
    partial class APIAnimalShelterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("APIAnimalShelter.Models.Cat", b =>
                {
                    b.Property<int>("CatId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Breed");

                    b.Property<string>("Coloring");

                    b.Property<DateTime>("DateAvailable");

                    b.Property<string>("Name");

                    b.Property<string>("Personality");

                    b.Property<string>("Sex");

                    b.HasKey("CatId");

                    b.ToTable("Cats");
                });

            modelBuilder.Entity("APIAnimalShelter.Models.Dog", b =>
                {
                    b.Property<int>("DogId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Breed");

                    b.Property<string>("Coloring");

                    b.Property<DateTime>("DateAvailable");

                    b.Property<string>("Name");

                    b.Property<string>("Personality");

                    b.Property<string>("Sex");

                    b.HasKey("DogId");

                    b.ToTable("Dogs");
                });
#pragma warning restore 612, 618
        }
    }
}

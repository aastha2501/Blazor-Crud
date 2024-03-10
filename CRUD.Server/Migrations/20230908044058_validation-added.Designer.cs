﻿// <auto-generated />
using System;
using CRUD.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRUD.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230908044058_validation-added")]
    partial class validationadded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CRUD.Shared.Models.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3e3ff311-3cff-457f-a8a8-2cc2df894aad"),
                            Author = "Amish Tripathy",
                            CategoryId = "55b7a860-9f40-47c4-9cbb-f72b808921c8",
                            Description = "The Secret of the Nagas is the second book of Amish Tripathi, second book of Amishverse, and also the second book of Shiva Trilogy. The story takes place in the imaginary land of Meluha and narrates how the inhabitants of that land are saved from their wars by a nomad named Shiva. It begins from where its predecessor, The Immortals of Meluha, left off, with Shiva trying to save Sati from the invading Naga. Later Shiva takes his troop of soldiers and travels far east to the land of Branga, where he wishes to find a clue to reach the Naga people. Shiva also learns that Sati's first child is still alive, as well as her twin sister. His journey ultimately leads him to the Naga capital of Panchavati, where he finds a surprise waiting for him.",
                            Title = "The Secret of the Nagas"
                        },
                        new
                        {
                            Id = new Guid("10b11b92-1305-4882-9703-f6545725c2cf"),
                            Author = "Amish Tripathy",
                            CategoryId = "55b7a860-9f40-47c4-9cbb-f72b808921c8",
                            Description = "During a trip Janak, the king of Mithila and his wife Sunaina find a child on the road, being protected by a vulture. They adopt the child and name her Sita, for she was found in a furrow. As an adolescent, Sita is sent to the ashram of Rishi Shvetaketu for her studies. There she learns about martial arts and gains knowledge on different subjects. She also makes friendship with a girl Radhika, and her cousin Hanuman, who was a Vayuputra—the tribe left by the previous Mahadev, Lord Rudra. He is also a Naga whose appearance looks like the head of a monkey placed on a human body.",
                            Title = "Sita the Warrior"
                        });
                });

            modelBuilder.Entity("CRUD.Shared.Models.Category", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = "55b7a860-9f40-47c4-9cbb-f72b808921c8",
                            Name = "Fiction"
                        },
                        new
                        {
                            Id = "44db7a33-d170-4c47-bcdc-adb8f1f7c834",
                            Name = "Ethical"
                        });
                });

            modelBuilder.Entity("CRUD.Shared.Models.Book", b =>
                {
                    b.HasOne("CRUD.Shared.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}

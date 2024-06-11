﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using csumathboy.CleanArch.Infrastructure.Data;

#nullable disable

namespace csumathboy.CleanArch.Infrastructure.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240608062952_Project")]
    partial class Project
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("csumathboy.CleanArch.Core.ContributorAggregate.Contributor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Contributors");
                });

            modelBuilder.Entity("csumathboy.CleanArch.Core.ProjectAggregate.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("csumathboy.CleanArch.Core.ProjectAggregate.ToDoItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ContributorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDone")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("ToDoItems");
                });

            modelBuilder.Entity("csumathboy.CleanArch.Core.ContributorAggregate.Contributor", b =>
                {
                    b.OwnsOne("csumathboy.CleanArch.Core.ContributorAggregate.PhoneNumber", "PhoneNumber", b1 =>
                        {
                            b1.Property<int>("ContributorId")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("CountryCode")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("Extension")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Number")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.HasKey("ContributorId");

                            b1.ToTable("Contributors");

                            b1.WithOwner()
                                .HasForeignKey("ContributorId");
                        });

                    b.Navigation("PhoneNumber");
                });

            modelBuilder.Entity("csumathboy.CleanArch.Core.ProjectAggregate.ToDoItem", b =>
                {
                    b.HasOne("csumathboy.CleanArch.Core.ProjectAggregate.Project", null)
                        .WithMany("Items")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("csumathboy.CleanArch.Core.ProjectAggregate.Project", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}

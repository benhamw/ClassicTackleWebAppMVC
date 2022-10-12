﻿// <auto-generated />
using FlyrodWebAppMVC;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FlyrodWebAppMVC.Migrations
{
    [DbContext(typeof(FlyrodContext))]
    [Migration("20221012230131_AddedRodImage")]
    partial class AddedRodImage
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FlyrodWebAppMVC.Models.Flyrod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Construction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("LengthFeet")
                        .HasColumnType("float");

                    b.Property<string>("LineWeight")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MakerId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RodImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sections")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearMade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MakerId");

                    b.ToTable("Flyrods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Construction = "Hex",
                            LengthFeet = 6.0,
                            LineWeight = "WF4",
                            MakerId = 1,
                            Model = "37H",
                            RodImage = "",
                            Sections = 2,
                            Type = "Bamboo",
                            YearMade = 1959
                        },
                        new
                        {
                            Id = 2,
                            Construction = "Hex",
                            LengthFeet = 7.0,
                            LineWeight = "DT4",
                            MakerId = 2,
                            Model = "98",
                            RodImage = "",
                            Sections = 2,
                            Type = "Bamboo",
                            YearMade = 1962
                        },
                        new
                        {
                            Id = 3,
                            Construction = "Hex",
                            LengthFeet = 7.5,
                            LineWeight = "DT5",
                            MakerId = 3,
                            Model = "Far and Fine",
                            RodImage = "",
                            Sections = 2,
                            Type = "Bamboo",
                            YearMade = 1972
                        },
                        new
                        {
                            Id = 4,
                            Construction = "Hex",
                            LengthFeet = 8.5,
                            LineWeight = "DT7",
                            MakerId = 9,
                            Model = "SF8672",
                            RodImage = "",
                            Sections = 2,
                            Type = "Bamboo",
                            YearMade = 1962
                        },
                        new
                        {
                            Id = 5,
                            Construction = "Penta",
                            LengthFeet = 7.5,
                            LineWeight = "DT5",
                            MakerId = 4,
                            Model = "7513",
                            RodImage = "",
                            Sections = 2,
                            Type = "Bamboo",
                            YearMade = 1955
                        },
                        new
                        {
                            Id = 6,
                            Construction = "Hex",
                            LengthFeet = 8.5,
                            LineWeight = "WF6",
                            MakerId = 5,
                            Model = "B9",
                            RodImage = "",
                            Sections = 2,
                            Type = "Bamboo",
                            YearMade = 1946
                        },
                        new
                        {
                            Id = 7,
                            Construction = "Quad",
                            LengthFeet = 7.5,
                            LineWeight = "WF6",
                            MakerId = 6,
                            Model = "37",
                            RodImage = "",
                            Sections = 2,
                            Type = "Bamboo",
                            YearMade = 1950
                        },
                        new
                        {
                            Id = 8,
                            Construction = "Hex",
                            LengthFeet = 8.5,
                            LineWeight = "DT7",
                            MakerId = 7,
                            Model = "Medallion",
                            RodImage = "",
                            Sections = 2,
                            Type = "Bamboo",
                            YearMade = 1975
                        },
                        new
                        {
                            Id = 9,
                            Construction = "Tubular",
                            LengthFeet = 8.0,
                            LineWeight = "WF6",
                            MakerId = 8,
                            Model = "FF80",
                            RodImage = "",
                            Sections = 2,
                            Type = "Fiberglass",
                            YearMade = 1977
                        },
                        new
                        {
                            Id = 10,
                            Construction = "Tubular",
                            LengthFeet = 7.5,
                            LineWeight = "WF6",
                            MakerId = 3,
                            Model = "Fullflex A",
                            RodImage = "",
                            Sections = 2,
                            Type = "Fiberglass",
                            YearMade = 1977
                        },
                        new
                        {
                            Id = 11,
                            Construction = "Tubular",
                            LengthFeet = 8.0,
                            LineWeight = "WF4",
                            MakerId = 9,
                            Model = "Stalker",
                            RodImage = "",
                            Sections = 2,
                            Type = "Fiberglass",
                            YearMade = 1979
                        });
                });

            modelBuilder.Entity("FlyrodWebAppMVC.Models.Maker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearFounded")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Makers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Leonard",
                            Type = "Company",
                            YearFounded = 1933
                        },
                        new
                        {
                            Id = 2,
                            Name = "Payne",
                            Type = "Company",
                            YearFounded = 1929
                        },
                        new
                        {
                            Id = 3,
                            Name = "Orvis",
                            Type = "Company",
                            YearFounded = 1889
                        },
                        new
                        {
                            Id = 4,
                            Name = "Uslan",
                            Type = "Individual",
                            YearFounded = 1933
                        },
                        new
                        {
                            Id = 5,
                            Name = "EC Powell",
                            Type = "Company",
                            YearFounded = 1919
                        },
                        new
                        {
                            Id = 6,
                            Name = "WE Edwards",
                            Type = "Individual",
                            YearFounded = 1940
                        },
                        new
                        {
                            Id = 7,
                            Name = "Browning Silaflex",
                            Type = "Company",
                            YearFounded = 1970
                        },
                        new
                        {
                            Id = 8,
                            Name = "Fenwick",
                            Type = "Company",
                            YearFounded = 1972
                        },
                        new
                        {
                            Id = 9,
                            Name = "Winston",
                            Type = "Company",
                            YearFounded = 1933
                        });
                });

            modelBuilder.Entity("FlyrodWebAppMVC.Models.Flyrod", b =>
                {
                    b.HasOne("FlyrodWebAppMVC.Models.Maker", "Maker")
                        .WithMany("Flyrods")
                        .HasForeignKey("MakerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Maker");
                });

            modelBuilder.Entity("FlyrodWebAppMVC.Models.Maker", b =>
                {
                    b.Navigation("Flyrods");
                });
#pragma warning restore 612, 618
        }
    }
}

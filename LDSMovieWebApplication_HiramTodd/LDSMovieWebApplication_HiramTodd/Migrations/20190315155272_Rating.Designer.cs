using System;
using LDSMovieWebApplication_HiramTodd.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    [Migration("20190315155272_Rating")]
    partial class Rating
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LDSMovieWebApplication_HiramTodd.Models.Movie", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Genre");

                b.Property<decimal>("Price")
                    .HasColumnType("decimal(18, 2)");

                b.Property<string>("Rating");

                b.Property<DateTime>("ReleaseDate");

                b.Property<string>("Title");

                b.HasKey("Id");

                b.ToTable("Movie");
            });
#pragma warning restore 612, 618
        }
    }
}
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebApi;

namespace webapi.Migrations
{
    [DbContext(typeof(StandUpContext))]
    [Migration("20170628193947_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApi.Presentation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Presentations");
                });

            modelBuilder.Entity("WebApi.Section", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<long>("PresentationId");

                    b.HasKey("Id");

                    b.HasIndex("PresentationId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("WebApi.Section", b =>
                {
                    b.HasOne("WebApi.Presentation", "Presentation")
                        .WithMany("Sections")
                        .HasForeignKey("PresentationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}

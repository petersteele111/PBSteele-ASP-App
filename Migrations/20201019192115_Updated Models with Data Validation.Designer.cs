﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PBsteele.Models;

namespace PBsteele.Migrations
{
    [DbContext(typeof(PBSteeleContext))]
    [Migration("20201019192115_Updated Models with Data Validation")]
    partial class UpdatedModelswithDataValidation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("identityUsers");
                });

            modelBuilder.Entity("PBsteele.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(14)")
                        .HasMaxLength(14);

                    b.HasKey("AuthorId");

                    b.ToTable("Author");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            Email = "petersteele@gmail.com",
                            Name = "Peter Steele",
                            Phone = "231-357-1970"
                        },
                        new
                        {
                            AuthorId = 2,
                            Email = "lbalbach@nmc.edu",
                            Name = "Lisa Balbach",
                            Phone = "231-645-5555"
                        },
                        new
                        {
                            AuthorId = 3,
                            Email = "mjones@example.com",
                            Name = "Mark Jones",
                            Phone = "555-555-1234"
                        });
                });

            modelBuilder.Entity("PBsteele.Models.Blog", b =>
                {
                    b.Property<int>("BlogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Post")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("Title")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("BlogID");

                    b.HasIndex("AuthorId");

                    b.ToTable("Blog");

                    b.HasData(
                        new
                        {
                            BlogID = 1,
                            AuthorId = 1,
                            Created = new DateTime(2020, 6, 5, 5, 10, 20, 0, DateTimeKind.Unspecified),
                            LastModified = new DateTime(2020, 6, 8, 15, 32, 12, 0, DateTimeKind.Unspecified),
                            Post = "This is a blog post. I hope you enjoy my blog and find the information entertaining! I will now post some Lorem Ipsum Text to fill in the rest of the space. Ea ratione ut et laboriosam voluptate expedita eos. Exercitationem asperiores repellendus nisi voluptatem est eum tempora id. Temporibus nesciunt ullam et voluptate sint itaque harum. Quas corrupti omnis omnis sit sint numquam atque deleniti. Voluptatem voluptas quo similique est facilis accusantium Vel qui deserunt odit et nobis.Architecto quas provident eius exercitationem officiis culpa.Dolorem vitae eveniet expedita delectus deleniti.Facilis laborum distinctio error sed necessitatibus.Accusamus ea illo rem.Enim ut saepe magni aut laborum. Impedit nihil maiores quo nihil.Asperiores voluptas voluptatem aut similique consectetur.Aspernatur ab nesciunt veritatis ut.Officia dolorem qui nesciunt ratione sint quas excepturi.Similique blanditiis sed aut est fugit et qui asperiores.Occaecati possimus labore repellat sapiente quo ut. Mollitia explicabo ut eveniet.Voluptatem accusamus quia voluptatem neque.Placeat itaque laboriosam excepturi possimus sed cumque. Ut totam delectus aut nihil est.Harum cupiditate ab eius consequatur non ea.Et ea voluptatum tempora consequuntur ut dignissimos aperiam nam.",
                            Title = "First Blog Post!"
                        },
                        new
                        {
                            BlogID = 2,
                            AuthorId = 2,
                            Created = new DateTime(2020, 7, 4, 12, 48, 0, 0, DateTimeKind.Unspecified),
                            LastModified = new DateTime(2020, 7, 21, 17, 25, 32, 0, DateTimeKind.Unspecified),
                            Post = "This is a blog post. I hope you enjoy my blog and find the information entertaining! I will now post some Lorem Ipsum Text to fill in the rest of the space. Ea ratione ut et laboriosam voluptate expedita eos. Exercitationem asperiores repellendus nisi voluptatem est eum tempora id. Temporibus nesciunt ullam et voluptate sint itaque harum. Quas corrupti omnis omnis sit sint numquam atque deleniti. Voluptatem voluptas quo similique est facilis accusantium Vel qui deserunt odit et nobis.Architecto quas provident eius exercitationem officiis culpa.Dolorem vitae eveniet expedita delectus deleniti.Facilis laborum distinctio error sed necessitatibus.Accusamus ea illo rem.Enim ut saepe magni aut laborum. Impedit nihil maiores quo nihil.Asperiores voluptas voluptatem aut similique consectetur.Aspernatur ab nesciunt veritatis ut.Officia dolorem qui nesciunt ratione sint quas excepturi.Similique blanditiis sed aut est fugit et qui asperiores.Occaecati possimus labore repellat sapiente quo ut. Mollitia explicabo ut eveniet.Voluptatem accusamus quia voluptatem neque.Placeat itaque laboriosam excepturi possimus sed cumque. Ut totam delectus aut nihil est.Harum cupiditate ab eius consequatur non ea.Et ea voluptatum tempora consequuntur ut dignissimos aperiam nam.",
                            Title = "Second Blog Post!"
                        },
                        new
                        {
                            BlogID = 3,
                            AuthorId = 3,
                            Created = new DateTime(2020, 9, 1, 16, 10, 12, 0, DateTimeKind.Unspecified),
                            LastModified = new DateTime(2020, 9, 1, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            Post = "This is a blog post. I hope you enjoy my blog and find the information entertaining! I will now post some Lorem Ipsum Text to fill in the rest of the space. Ea ratione ut et laboriosam voluptate expedita eos. Exercitationem asperiores repellendus nisi voluptatem est eum tempora id. Temporibus nesciunt ullam et voluptate sint itaque harum. Quas corrupti omnis omnis sit sint numquam atque deleniti. Voluptatem voluptas quo similique est facilis accusantium Vel qui deserunt odit et nobis.Architecto quas provident eius exercitationem officiis culpa.Dolorem vitae eveniet expedita delectus deleniti.Facilis laborum distinctio error sed necessitatibus.Accusamus ea illo rem.Enim ut saepe magni aut laborum. Impedit nihil maiores quo nihil.Asperiores voluptas voluptatem aut similique consectetur.Aspernatur ab nesciunt veritatis ut.Officia dolorem qui nesciunt ratione sint quas excepturi.Similique blanditiis sed aut est fugit et qui asperiores.Occaecati possimus labore repellat sapiente quo ut. Mollitia explicabo ut eveniet.Voluptatem accusamus quia voluptatem neque.Placeat itaque laboriosam excepturi possimus sed cumque. Ut totam delectus aut nihil est.Harum cupiditate ab eius consequatur non ea.Et ea voluptatum tempora consequuntur ut dignissimos aperiam nam.",
                            Title = "Third Blog Post!"
                        },
                        new
                        {
                            BlogID = 4,
                            AuthorId = 1,
                            Created = new DateTime(2020, 9, 21, 14, 35, 56, 0, DateTimeKind.Unspecified),
                            LastModified = new DateTime(2020, 9, 21, 14, 58, 12, 0, DateTimeKind.Unspecified),
                            Post = "This is a blog post. I hope you enjoy my blog and find the information entertaining! I will now post some Lorem Ipsum Text to fill in the rest of the space. Ea ratione ut et laboriosam voluptate expedita eos. Exercitationem asperiores repellendus nisi voluptatem est eum tempora id. Temporibus nesciunt ullam et voluptate sint itaque harum. Quas corrupti omnis omnis sit sint numquam atque deleniti. Voluptatem voluptas quo similique est facilis accusantium Vel qui deserunt odit et nobis.Architecto quas provident eius exercitationem officiis culpa.Dolorem vitae eveniet expedita delectus deleniti.Facilis laborum distinctio error sed necessitatibus.Accusamus ea illo rem.Enim ut saepe magni aut laborum. Impedit nihil maiores quo nihil.Asperiores voluptas voluptatem aut similique consectetur.Aspernatur ab nesciunt veritatis ut.Officia dolorem qui nesciunt ratione sint quas excepturi.Similique blanditiis sed aut est fugit et qui asperiores.Occaecati possimus labore repellat sapiente quo ut. Mollitia explicabo ut eveniet.Voluptatem accusamus quia voluptatem neque.Placeat itaque laboriosam excepturi possimus sed cumque. Ut totam delectus aut nihil est.Harum cupiditate ab eius consequatur non ea.Et ea voluptatum tempora consequuntur ut dignissimos aperiam nam.",
                            Title = "Fourth Blog Post!"
                        });
                });

            modelBuilder.Entity("PBsteele.Models.Blog", b =>
                {
                    b.HasOne("PBsteele.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

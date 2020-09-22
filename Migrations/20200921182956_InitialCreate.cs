using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PBsteele.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    BlogID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    Post = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.BlogID);
                });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogID", "Author", "Created", "LastModified", "Post", "Title" },
                values: new object[,]
                {
                    { 1, "Peter Steele", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1990), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1990), "This is a blog post. I hope you enjoy my blog and find the information entertaining! I will now post some Lorem Ipsum Text to fill in the rest of the space. Ea ratione ut et laboriosam voluptate expedita eos. Exercitationem asperiores repellendus nisi voluptatem est eum tempora id. Temporibus nesciunt ullam et voluptate sint itaque harum. Quas corrupti omnis omnis sit sint numquam atque deleniti. Voluptatem voluptas quo similique est facilis accusantium Vel qui deserunt odit et nobis.Architecto quas provident eius exercitationem officiis culpa.Dolorem vitae eveniet expedita delectus deleniti.Facilis laborum distinctio error sed necessitatibus.Accusamus ea illo rem.Enim ut saepe magni aut laborum. Impedit nihil maiores quo nihil.Asperiores voluptas voluptatem aut similique consectetur.Aspernatur ab nesciunt veritatis ut.Officia dolorem qui nesciunt ratione sint quas excepturi.Similique blanditiis sed aut est fugit et qui asperiores.Occaecati possimus labore repellat sapiente quo ut. Mollitia explicabo ut eveniet.Voluptatem accusamus quia voluptatem neque.Placeat itaque laboriosam excepturi possimus sed cumque. Ut totam delectus aut nihil est.Harum cupiditate ab eius consequatur non ea.Et ea voluptatum tempora consequuntur ut dignissimos aperiam nam.", "First Blog Post!" },
                    { 2, "Peter Steele", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1990), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1990), "This is a blog post. I hope you enjoy my blog and find the information entertaining! I will now post some Lorem Ipsum Text to fill in the rest of the space. Ea ratione ut et laboriosam voluptate expedita eos. Exercitationem asperiores repellendus nisi voluptatem est eum tempora id. Temporibus nesciunt ullam et voluptate sint itaque harum. Quas corrupti omnis omnis sit sint numquam atque deleniti. Voluptatem voluptas quo similique est facilis accusantium Vel qui deserunt odit et nobis.Architecto quas provident eius exercitationem officiis culpa.Dolorem vitae eveniet expedita delectus deleniti.Facilis laborum distinctio error sed necessitatibus.Accusamus ea illo rem.Enim ut saepe magni aut laborum. Impedit nihil maiores quo nihil.Asperiores voluptas voluptatem aut similique consectetur.Aspernatur ab nesciunt veritatis ut.Officia dolorem qui nesciunt ratione sint quas excepturi.Similique blanditiis sed aut est fugit et qui asperiores.Occaecati possimus labore repellat sapiente quo ut. Mollitia explicabo ut eveniet.Voluptatem accusamus quia voluptatem neque.Placeat itaque laboriosam excepturi possimus sed cumque. Ut totam delectus aut nihil est.Harum cupiditate ab eius consequatur non ea.Et ea voluptatum tempora consequuntur ut dignissimos aperiam nam.", "Second Blog Post!" },
                    { 3, "Peter Steele", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1990), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1990), "This is a blog post. I hope you enjoy my blog and find the information entertaining! I will now post some Lorem Ipsum Text to fill in the rest of the space. Ea ratione ut et laboriosam voluptate expedita eos. Exercitationem asperiores repellendus nisi voluptatem est eum tempora id. Temporibus nesciunt ullam et voluptate sint itaque harum. Quas corrupti omnis omnis sit sint numquam atque deleniti. Voluptatem voluptas quo similique est facilis accusantium Vel qui deserunt odit et nobis.Architecto quas provident eius exercitationem officiis culpa.Dolorem vitae eveniet expedita delectus deleniti.Facilis laborum distinctio error sed necessitatibus.Accusamus ea illo rem.Enim ut saepe magni aut laborum. Impedit nihil maiores quo nihil.Asperiores voluptas voluptatem aut similique consectetur.Aspernatur ab nesciunt veritatis ut.Officia dolorem qui nesciunt ratione sint quas excepturi.Similique blanditiis sed aut est fugit et qui asperiores.Occaecati possimus labore repellat sapiente quo ut. Mollitia explicabo ut eveniet.Voluptatem accusamus quia voluptatem neque.Placeat itaque laboriosam excepturi possimus sed cumque. Ut totam delectus aut nihil est.Harum cupiditate ab eius consequatur non ea.Et ea voluptatum tempora consequuntur ut dignissimos aperiam nam.", "Third Blog Post!" },
                    { 4, "Peter Steele", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1990), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1990), "This is a blog post. I hope you enjoy my blog and find the information entertaining! I will now post some Lorem Ipsum Text to fill in the rest of the space. Ea ratione ut et laboriosam voluptate expedita eos. Exercitationem asperiores repellendus nisi voluptatem est eum tempora id. Temporibus nesciunt ullam et voluptate sint itaque harum. Quas corrupti omnis omnis sit sint numquam atque deleniti. Voluptatem voluptas quo similique est facilis accusantium Vel qui deserunt odit et nobis.Architecto quas provident eius exercitationem officiis culpa.Dolorem vitae eveniet expedita delectus deleniti.Facilis laborum distinctio error sed necessitatibus.Accusamus ea illo rem.Enim ut saepe magni aut laborum. Impedit nihil maiores quo nihil.Asperiores voluptas voluptatem aut similique consectetur.Aspernatur ab nesciunt veritatis ut.Officia dolorem qui nesciunt ratione sint quas excepturi.Similique blanditiis sed aut est fugit et qui asperiores.Occaecati possimus labore repellat sapiente quo ut. Mollitia explicabo ut eveniet.Voluptatem accusamus quia voluptatem neque.Placeat itaque laboriosam excepturi possimus sed cumque. Ut totam delectus aut nihil est.Harum cupiditate ab eius consequatur non ea.Et ea voluptatum tempora consequuntur ut dignissimos aperiam nam.", "Fourth Blog Post!" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blog");
        }
    }
}

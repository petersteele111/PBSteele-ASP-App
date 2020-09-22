using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PBsteele.Models
{
    public class PBSteeleContext : DbContext
    {
        public PBSteeleContext(DbContextOptions<PBSteeleContext> options) : base(options)
        {

        }

        public DbSet<Blog> Blog { get; set; }
        public DbSet<IdentityUser> identityUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    BlogID = 1,
                    Title = "First Blog Post!",
                    Created = new DateTime(2020, 6, 05, 5, 10, 20),
                    LastModified = new DateTime(2020, 6, 08, 15, 32, 12),
                    Post = "This is a blog post. I hope you enjoy my blog and find the information entertaining! I will now post some Lorem Ipsum Text to fill in the rest of the space. Ea ratione ut et laboriosam voluptate expedita eos. Exercitationem asperiores repellendus nisi voluptatem est eum tempora id. Temporibus nesciunt ullam et voluptate sint itaque harum. Quas corrupti omnis omnis sit sint numquam atque deleniti. Voluptatem voluptas quo similique est facilis accusantium Vel qui deserunt odit et nobis.Architecto quas provident eius exercitationem officiis culpa.Dolorem vitae eveniet expedita delectus deleniti.Facilis laborum distinctio error sed necessitatibus.Accusamus ea illo rem.Enim ut saepe magni aut laborum. Impedit nihil maiores quo nihil.Asperiores voluptas voluptatem aut similique consectetur.Aspernatur ab nesciunt veritatis ut.Officia dolorem qui nesciunt ratione sint quas excepturi.Similique blanditiis sed aut est fugit et qui asperiores.Occaecati possimus labore repellat sapiente quo ut. Mollitia explicabo ut eveniet.Voluptatem accusamus quia voluptatem neque.Placeat itaque laboriosam excepturi possimus sed cumque. Ut totam delectus aut nihil est.Harum cupiditate ab eius consequatur non ea.Et ea voluptatum tempora consequuntur ut dignissimos aperiam nam.",
                    Author = "Peter Steele"
                },

                new Blog
                {
                    BlogID = 2,
                    Title = "Second Blog Post!",
                    Created = new DateTime(2020, 7, 04, 12, 48, 00),
                    LastModified = new DateTime(2020, 7, 21, 17, 25, 32),
                    Post = "This is a blog post. I hope you enjoy my blog and find the information entertaining! I will now post some Lorem Ipsum Text to fill in the rest of the space. Ea ratione ut et laboriosam voluptate expedita eos. Exercitationem asperiores repellendus nisi voluptatem est eum tempora id. Temporibus nesciunt ullam et voluptate sint itaque harum. Quas corrupti omnis omnis sit sint numquam atque deleniti. Voluptatem voluptas quo similique est facilis accusantium Vel qui deserunt odit et nobis.Architecto quas provident eius exercitationem officiis culpa.Dolorem vitae eveniet expedita delectus deleniti.Facilis laborum distinctio error sed necessitatibus.Accusamus ea illo rem.Enim ut saepe magni aut laborum. Impedit nihil maiores quo nihil.Asperiores voluptas voluptatem aut similique consectetur.Aspernatur ab nesciunt veritatis ut.Officia dolorem qui nesciunt ratione sint quas excepturi.Similique blanditiis sed aut est fugit et qui asperiores.Occaecati possimus labore repellat sapiente quo ut. Mollitia explicabo ut eveniet.Voluptatem accusamus quia voluptatem neque.Placeat itaque laboriosam excepturi possimus sed cumque. Ut totam delectus aut nihil est.Harum cupiditate ab eius consequatur non ea.Et ea voluptatum tempora consequuntur ut dignissimos aperiam nam.",
                    Author = "Peter Steele"
                },

                new Blog
                {
                    BlogID = 3,
                    Title = "Third Blog Post!",
                    Created = new DateTime(2020, 9, 01, 16, 10, 12),
                    LastModified = new DateTime(2020, 9, 01, 17, 00, 00),
                    Post = "This is a blog post. I hope you enjoy my blog and find the information entertaining! I will now post some Lorem Ipsum Text to fill in the rest of the space. Ea ratione ut et laboriosam voluptate expedita eos. Exercitationem asperiores repellendus nisi voluptatem est eum tempora id. Temporibus nesciunt ullam et voluptate sint itaque harum. Quas corrupti omnis omnis sit sint numquam atque deleniti. Voluptatem voluptas quo similique est facilis accusantium Vel qui deserunt odit et nobis.Architecto quas provident eius exercitationem officiis culpa.Dolorem vitae eveniet expedita delectus deleniti.Facilis laborum distinctio error sed necessitatibus.Accusamus ea illo rem.Enim ut saepe magni aut laborum. Impedit nihil maiores quo nihil.Asperiores voluptas voluptatem aut similique consectetur.Aspernatur ab nesciunt veritatis ut.Officia dolorem qui nesciunt ratione sint quas excepturi.Similique blanditiis sed aut est fugit et qui asperiores.Occaecati possimus labore repellat sapiente quo ut. Mollitia explicabo ut eveniet.Voluptatem accusamus quia voluptatem neque.Placeat itaque laboriosam excepturi possimus sed cumque. Ut totam delectus aut nihil est.Harum cupiditate ab eius consequatur non ea.Et ea voluptatum tempora consequuntur ut dignissimos aperiam nam.",
                    Author = "Peter Steele"
                },

                new Blog
                {
                    BlogID = 4,
                    Title = "Fourth Blog Post!",
                    Created = new DateTime(2020, 9, 21, 14, 35, 56),
                    LastModified = new DateTime(2020, 9, 21, 14, 58, 12),
                    Post = "This is a blog post. I hope you enjoy my blog and find the information entertaining! I will now post some Lorem Ipsum Text to fill in the rest of the space. Ea ratione ut et laboriosam voluptate expedita eos. Exercitationem asperiores repellendus nisi voluptatem est eum tempora id. Temporibus nesciunt ullam et voluptate sint itaque harum. Quas corrupti omnis omnis sit sint numquam atque deleniti. Voluptatem voluptas quo similique est facilis accusantium Vel qui deserunt odit et nobis.Architecto quas provident eius exercitationem officiis culpa.Dolorem vitae eveniet expedita delectus deleniti.Facilis laborum distinctio error sed necessitatibus.Accusamus ea illo rem.Enim ut saepe magni aut laborum. Impedit nihil maiores quo nihil.Asperiores voluptas voluptatem aut similique consectetur.Aspernatur ab nesciunt veritatis ut.Officia dolorem qui nesciunt ratione sint quas excepturi.Similique blanditiis sed aut est fugit et qui asperiores.Occaecati possimus labore repellat sapiente quo ut. Mollitia explicabo ut eveniet.Voluptatem accusamus quia voluptatem neque.Placeat itaque laboriosam excepturi possimus sed cumque. Ut totam delectus aut nihil est.Harum cupiditate ab eius consequatur non ea.Et ea voluptatum tempora consequuntur ut dignissimos aperiam nam.",
                    Author = "Peter Steele"
                }

                );
        }
    }
}

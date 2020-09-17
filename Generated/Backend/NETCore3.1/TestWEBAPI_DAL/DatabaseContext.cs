using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TestWebAPI_BL;

namespace TestWEBAPI_DAL
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {

        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
        {
        }

            public virtual DbSet<articles> articles{ get; set; }
                    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<articles>()
                .ToTable("articles")
                .HasKey(it=>it.id20200916234906);
         
            OnModelCreatingPartial(modelBuilder);
            Seed(modelBuilder);
        }
        void Seed(ModelBuilder modelBuilder){


                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 1 , id = 1M, title = @"Dignissimos voluptas amet dolores numquam omnis.", description = @"Unde magnam fugiat doloribus provident totam. Similique est alias laudantium odio. Vel explicabo totam culpa sunt adipisci consequatur dolor. Aut dolor hic voluptate quod in nihil quis. Illum doloribus iusto autem eaque ipsam.", created_at = 44042.5091435185M, updated_at = 44042.5091435185M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 2 , id = 2M, title = @"Adipisci eaque vitae adipisci quaerat qui.", description = @"Possimus maiores harum saepe eveniet aspernatur repellendus et. Accusantium voluptatem ipsa ut. Qui et nemo nostrum. Animi eligendi illum vel sed ut vel. Ut voluptatem autem iusto suscipit nihil tempore et dolorem.", created_at = 44042.5091435185M, updated_at = 44042.5091435185M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 3 , id = 3M, title = @"Harum consequatur earum totam quam tenetur eos enim.", description = @"Repellendus autem et possimus voluptates illum. Nihil cumque aspernatur et blanditiis sed laudantium. Vel nesciunt ut qui consequuntur et qui accusantium. Optio quaerat aut quo dolores.", created_at = 44042.5091435185M, updated_at = 44042.5091435185M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 4 , id = 4M, title = @"Minus cupiditate necessitatibus ipsa optio.", description = @"Eveniet qui commodi est blanditiis saepe. Voluptas eum reiciendis vitae. Et qui ex placeat accusamus vero nostrum qui fuga. Provident quam impedit id consequatur sunt officia iusto.", created_at = 44042.5091435185M, updated_at = 44042.5091435185M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 5 , id = 5M, title = @"Nostrum rerum id aliquam aspernatur eligendi.", description = @"Optio explicabo qui tempora consequuntur eius sit. Ducimus nihil illo consectetur eum voluptatem officia sit. Et eos qui quia et laudantium error quia.", created_at = 44042.5091435185M, updated_at = 44042.5091435185M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 6 , id = 6M, title = @"Sit laudantium hic neque dicta.", description = @"Non veritatis sint itaque labore doloribus dolor provident. Dolore corporis omnis quibusdam voluptatibus. Molestiae consequatur quia similique consequuntur. Dolores dolore aliquam sapiente qui pariatur reiciendis.", created_at = 44042.5091435185M, updated_at = 44042.5091435185M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 7 , id = 7M, title = @"Doloremque odio repellendus omnis.", description = @"Asperiores et error soluta. Eveniet iste ex qui placeat dolore. Molestiae nesciunt iusto consequatur est. Quia repellat modi nesciunt eum.", created_at = 44042.5091435185M, updated_at = 44042.5091435185M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 8 , id = 8M, title = @"Est et quod et nam eius autem.", description = @"Quo dolorum ratione esse quibusdam voluptate. Nam eos voluptatem quia voluptas molestias fugiat molestias. Aut ut nam sed corporis eum magnam.", created_at = 44042.5091435185M, updated_at = 44042.5091435185M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 9 , id = 9M, title = @"Et non enim eos sit ipsa cum facilis.", description = @"Accusamus libero et aut ut tempore cum qui quod. Praesentium omnis ut modi qui quia. Id et in dolores. Ratione error ut et beatae rerum voluptatem assumenda.", created_at = 44042.5091435185M, updated_at = 44042.5091435185M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 10 , id = 10M, title = @"Aut blanditiis quo ipsa iusto.", description = @"Officia voluptatem et sed assumenda. Provident at accusamus laborum error harum. Libero distinctio est atque cum quia dignissimos.", created_at = 44042.5091435185M, updated_at = 44042.5091435185M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 11 , id = 11M, title = @"Voluptas quis provident sapiente.", description = @"Accusantium magnam consequatur maiores reiciendis. Omnis voluptatem iste nostrum quam quo. Non qui est quia excepturi iusto illo rerum.", created_at = 44042.5091435185M, updated_at = 44042.5091435185M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 12 , id = 12M, title = @"Cupiditate repudiandae facilis et beatae harum sed officia.", description = @"Ut corporis ea est laboriosam. Et quia animi similique omnis repellendus. Quia soluta et ducimus ullam veritatis ratione dolor.", created_at = 44042.5091435185M, updated_at = 44042.5091435185M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 13 , id = 13M, title = @"Delectus voluptate omnis ut unde et sunt.", description = @"Molestias et iusto amet sed sint aut dolor. Hic consequuntur eligendi quaerat consectetur. Cumque aut facere nostrum totam omnis enim quas. Suscipit nihil ut ipsa dolores impedit. Quia qui dolores dolorem earum id omnis.", created_at = 44042.5091435185M, updated_at = 44042.5091435185M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 14 , id = 14M, title = @"Minima repellat inventore veniam laudantium omnis vel maxime.", description = @"Commodi qui fugiat est. In sit et reprehenderit est vitae vitae. Eaque aliquam impedit voluptatem animi tempora voluptatem aut. Sit eius itaque deleniti aliquid voluptates aperiam deleniti.", created_at = 44042.5091435185M, updated_at = 44042.5091435185M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 15 , id = 15M, title = @"Recusandae fuga veritatis nam a tempora.", description = @"Sed iste non quis aperiam nemo autem aut. Non tempora quae libero velit inventore aliquid ea. Dignissimos fugit aspernatur aliquam voluptatem repudiandae occaecati perspiciatis. Recusandae consequatur consequatur sint ab corporis qui.", created_at = 44042.5091435185M, updated_at = 44042.5091435185M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 16 , id = 16M, title = @"Autem recusandae sit dolorem repellendus.", description = @"Quibusdam esse ex ut ad modi. Ut atque vel voluptatem esse voluptas.", created_at = 44042.5091435185M, updated_at = 44042.5091435185M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 17 , id = 17M, title = @"Debitis ipsa enim omnis et voluptatem officia.", description = @"Ipsam est quis et quo et non. Pariatur corrupti expedita nam numquam. Voluptatem iste autem modi sunt nesciunt et eum iste.", created_at = 44042.5091435185M, updated_at = 44042.5091435185M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 18 , id = 18M, title = @"Ipsam dolorem praesentium ipsa qui.", description = @"Quis voluptatem expedita deleniti. Voluptate aliquam ut suscipit unde facere vitae accusantium. Deleniti magni eum quis necessitatibus harum nam praesentium. Sit sed sit ducimus ut magni iste illum consequuntur.", created_at = 44042.5091435185M, updated_at = 44042.5091435185M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 19 , id = 19M, title = @"Eos dolore ipsa odit at ad harum minus quaerat.", description = @"Tempore rerum et ratione libero eaque adipisci. Perferendis quasi ut suscipit dolor. Quas voluptas in possimus qui eligendi nostrum. Modi sit quia eligendi nemo beatae id.", created_at = 44042.5091435185M, updated_at = 44042.5091435185M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 20 , id = 20M, title = @"Voluptate cumque consequatur consequatur praesentium adipisci ratione deleniti.", description = @"Nihil corporis nemo ad odit aperiam rerum. Dolores et sequi nihil harum quibusdam nemo. Ut eaque error reiciendis sed ea facere consequatur. Nobis repudiandae quas quos.", created_at = 44042.5091435185M, updated_at = 44042.5091435185M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 21 , id = 21M, title = @"Nobis et rerum sint ipsum repellat corrupti.", description = @"Odit a porro nam soluta quae veritatis tenetur. Exercitationem ut aut officiis odio soluta ut. Nam commodi officiis est sunt rerum.", created_at = 44042.5091435185M, updated_at = 44042.5091435185M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 22 , id = 22M, title = @"Ad error ex asperiores et voluptate aut.", description = @"Facere quaerat enim ipsum deserunt veniam doloremque. Ratione fugiat ipsa at dolorem ipsam. Omnis ad distinctio numquam facere deserunt et error.", created_at = 44042.5091435185M, updated_at = 44042.5091435185M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 23 , id = 23M, title = @"Non consequuntur accusantium totam qui.", description = @"Accusamus aut quia ut. Maiores et harum qui temporibus. Labore alias enim ea rerum iure magnam facere. Sed ipsam repellendus laborum aut sit recusandae debitis.", created_at = 44042.5091435185M, updated_at = 44042.5091435185M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 24 , id = 24M, title = @"Quas numquam neque excepturi itaque rerum molestiae omnis.", description = @"Sequi reprehenderit repellendus libero molestiae. Iusto similique nam et quam expedita. Hic reprehenderit repellat vel. Dolores omnis aut qui.", created_at = 44042.5091435185M, updated_at = 44042.5091435185M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 25 , id = 25M, title = @"Eligendi enim molestias totam quae.", description = @"Expedita incidunt odio nostrum quisquam officiis id. Iste vel doloribus voluptatibus. Tempore aut omnis esse ad. Quidem voluptatem quasi debitis.", created_at = 44042.5091435185M, updated_at = 44042.5091435185M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 26 , id = 26M, title = @"Nihil voluptas aut error nulla vel odio excepturi.", description = @"Cupiditate aliquid culpa commodi cumque saepe itaque. Recusandae doloremque magnam enim. Quaerat saepe nam magni praesentium reiciendis.", created_at = 44042.5091435185M, updated_at = 44042.5091435185M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 27 , id = 27M, title = @"Vero et quibusdam eveniet labore nobis animi reiciendis.", description = @"Similique qui dolor aut vero sint praesentium rerum adipisci. Atque numquam voluptatem omnis voluptates sed voluptas qui omnis. Qui omnis non repellendus dolor.", created_at = 44042.5091435185M, updated_at = 44042.5091435185M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 28 , id = 28M, title = @"Rem illo facere a quidem.", description = @"Ducimus molestiae excepturi totam fugit dolores. Repellendus tempora perspiciatis saepe voluptatem ipsam et vitae voluptate. Saepe debitis doloremque vitae molestias repellat. Ut eveniet sed quo id.", created_at = 44042.5091435185M, updated_at = 44042.5091435185M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 29 , id = 29M, title = @"Dolorem saepe sequi unde sed.", description = @"Earum nobis atque fugiat sunt laborum. Aut alias expedita natus ut ratione voluptatibus. Natus autem omnis maxime quas.", created_at = 44042.5091550926M, updated_at = 44042.5091550926M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 30 , id = 30M, title = @"Quis laudantium voluptatem libero tempora.", description = @"Veniam voluptas distinctio omnis magni nemo recusandae nulla. Delectus qui perspiciatis delectus quas et. Ut sed nihil facere dolorem. Et eum saepe excepturi doloremque in vero dolore.", created_at = 44042.5091550926M, updated_at = 44042.5091550926M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 31 , id = 31M, title = @"Tenetur cum iure accusamus dolore.", description = @"Et qui tenetur ratione in est sed. Sit accusamus et sit dolor.", created_at = 44042.5091550926M, updated_at = 44042.5091550926M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 32 , id = 32M, title = @"Esse natus odit sint molestiae quia velit.", description = @"Qui alias nisi eius illo et illum asperiores. Sint voluptate ipsam pariatur occaecati est at. Enim blanditiis suscipit eos quia ab nesciunt.", created_at = 44042.5091550926M, updated_at = 44042.5091550926M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 33 , id = 33M, title = @"Enim dolorem sed adipisci quod iure sequi quia.", description = @"Eum amet placeat qui quia ea explicabo debitis. Voluptatem ut nam consequuntur id quaerat praesentium laudantium. Hic consequatur ipsum sequi sit eum. Nam a provident in distinctio.", created_at = 44042.5091550926M, updated_at = 44042.5091550926M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 34 , id = 34M, title = @"Consectetur repudiandae sit at aut rerum.", description = @"Maxime ut id voluptatum et maxime. Ullam numquam molestias voluptas nostrum ipsa alias et. Accusantium mollitia laboriosam voluptatem sint et quae. Ex reiciendis tempore accusamus rem quis iusto.", created_at = 44042.5091550926M, updated_at = 44042.5091550926M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 35 , id = 35M, title = @"Saepe libero quis maxime perferendis blanditiis rerum.", description = @"Et quia soluta exercitationem. Ipsam et eum ad sapiente. Incidunt autem sed voluptatem.", created_at = 44042.5091550926M, updated_at = 44042.5091550926M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 36 , id = 36M, title = @"Possimus accusamus at amet est.", description = @"Quos excepturi dolor facilis at dolor quod autem. Quia id nisi quam odit molestiae reprehenderit debitis. Dolorum at aut quo laboriosam asperiores. Perferendis quam recusandae amet enim voluptatem totam ipsa excepturi.", created_at = 44042.5091550926M, updated_at = 44042.5091550926M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 37 , id = 37M, title = @"Explicabo et doloribus qui id possimus.", description = @"Est fugiat blanditiis blanditiis unde id ut ea fugit. Officia cupiditate nostrum recusandae necessitatibus eum et. Doloribus ut impedit ut inventore occaecati placeat velit ipsum. Consequatur debitis qui nulla.", created_at = 44042.5091550926M, updated_at = 44042.5091550926M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 38 , id = 38M, title = @"Quos sint numquam tempore consequatur.", description = @"Corrupti officia qui laudantium. Sit quia voluptatem sunt excepturi ipsam ut et. Velit ut placeat id illum eum quis aliquam vero.", created_at = 44042.5091550926M, updated_at = 44042.5091550926M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 39 , id = 39M, title = @"Modi omnis voluptatem ratione sint.", description = @"Alias aut atque minus. Sunt aut quo quos et cumque. Fugit saepe beatae ut dolore sapiente. Inventore deleniti hic tempora aliquid. Consequatur rerum cumque maiores illum.", created_at = 44042.5091550926M, updated_at = 44042.5091550926M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 40 , id = 40M, title = @"Voluptatum voluptatum eius voluptatum.", description = @"Sit velit dolorum voluptates aliquid quia. Velit magni dolor ex vel.", created_at = 44042.5091550926M, updated_at = 44042.5091550926M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 41 , id = 41M, title = @"Doloremque qui necessitatibus veniam dignissimos.", description = @"Accusamus omnis aspernatur provident et enim. Qui qui nam est aperiam et. Eveniet sequi blanditiis et quae ad et repudiandae. Vitae cupiditate voluptatem alias nemo ut sequi labore necessitatibus.", created_at = 44042.5091550926M, updated_at = 44042.5091550926M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 42 , id = 42M, title = @"Quibusdam molestias impedit dolore aut quidem reiciendis quis nihil.", description = @"Maxime inventore ad dicta distinctio corrupti tempore. Eius error delectus et. Maiores recusandae aut qui dolorem voluptatem enim. Optio blanditiis sit sapiente et cupiditate doloribus nulla.", created_at = 44042.5091550926M, updated_at = 44042.5091550926M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 43 , id = 43M, title = @"Doloribus et ipsam eligendi dolorem.", description = @"Eum sit porro quae consequatur esse omnis necessitatibus. Aspernatur laudantium sed ab facilis cupiditate sit. Ducimus et vel possimus necessitatibus itaque dolores. Libero laboriosam molestiae dignissimos autem.", created_at = 44042.5091550926M, updated_at = 44042.5091550926M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 44 , id = 44M, title = @"Voluptas corporis qui dolore aut doloremque qui ab.", description = @"Qui ut quia est ipsa et. Quis eos voluptatem quis. Eveniet aspernatur nesciunt laboriosam dolorum odit itaque. Qui quas eum sit.", created_at = 44042.5091550926M, updated_at = 44042.5091550926M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 45 , id = 45M, title = @"Aut nesciunt incidunt non nobis voluptatem.", description = @"Soluta autem architecto rerum repudiandae. Magnam quo omnis animi commodi et officiis in. Sapiente quae enim pariatur quia. Quaerat facere eos molestias quae tempore.", created_at = 44042.5091550926M, updated_at = 44042.5091550926M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 46 , id = 46M, title = @"Eius rerum est quos.", description = @"Dolorum possimus cum ratione aut quis molestiae. Eius quia excepturi et voluptatum. Earum dolor sequi facere. Omnis velit expedita voluptatem fugit nam dicta.", created_at = 44042.5091550926M, updated_at = 44042.5091550926M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 47 , id = 47M, title = @"Ea est quidem dignissimos iusto officia quisquam aspernatur dolore.", description = @"Sunt iure aut corporis quam est aut. Provident nostrum non architecto sed delectus. Corporis eum eaque modi molestiae vel dolores. Enim fugit aut neque. Quisquam et laboriosam facilis ea sunt.", created_at = 44042.5091550926M, updated_at = 44042.5091550926M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 48 , id = 48M, title = @"Veniam nam veniam quos ipsa commodi voluptates.", description = @"Dicta eligendi velit optio ipsa consequatur qui. Et assumenda nam dicta et. Culpa molestiae quisquam nobis. Repellendus libero eveniet in ex ratione repellendus. Excepturi ut neque ex ut qui magnam.", created_at = 44042.5091550926M, updated_at = 44042.5091550926M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 49 , id = 49M, title = @"Esse aperiam earum ad quia dolor sapiente.", description = @"Minus aperiam qui sit asperiores qui consequatur tenetur. Voluptatem possimus dolorem quisquam sit ut.", created_at = 44042.5091550926M, updated_at = 44042.5091550926M });
                    
                    modelBuilder.Entity<articles>().HasData(
                        new articles(){ id20200916234906 = 50 , id = 50M, title = @"Est dignissimos perferendis molestiae iste cupiditate quo eum vitae.", description = @"Qui ex consequatur sint. In enim rerum et molestias temporibus non voluptatibus. Sunt recusandae ipsa dolorem. Et nemo explicabo ex ipsam ut minus est qui. Voluptate incidunt ut id et sit qui facilis magni.", created_at = 44042.5091550926M, updated_at = 44042.5091550926M });
                    
            OnSeed(modelBuilder);


        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        partial void OnSeed(ModelBuilder modelBuilder);       
    }
}
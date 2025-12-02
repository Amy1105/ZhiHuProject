using Core.AppUserAggregate.Entites;
using Core.QuestionAggregate.Entites;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructure.Data
{
    public class AppDbContext (DbContextOptions<AppDbContext> options) :IdentityUserContext<IdentityUser,int>(options)
    {

        //这两种写法有什么区别 to do...
       // public DbSet<Question> questions { get; set; }
        public DbSet<Question> Questions=>Set<Question>();

        public DbSet<Answer> Answers=>Set<Answer>();

        public DbSet<AnswerLike> AnswerLikes=>Set<AnswerLike>();

        public DbSet<AppUser> AppUsers=>Set<AppUser>();

        public DbSet<FollowUser> FollowUsers=>Set<FollowUser>();

        public DbSet<FollowQuestion> FollowQuestions=>Set<FollowQuestion>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // to do...
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

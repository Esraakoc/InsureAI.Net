using InsurAI.NET.Entities;
using Microsoft.EntityFrameworkCore;

namespace InsurAI.NET.Context
{
    public class InsureContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-G55JK8H;initial catalog=InsureDb; integrated security=true;trust server certificate=true");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutItem> AboutItems { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<PricingPlan> PricingPlans { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<TrailerVideo> TrailerVideos { get; set; }
        //public DbSet<Comment> Comments { get; set; }
        //public DbSet<PricingPlanItem> PricingPlanItems { get; set; }
        //public DbSet<Gallery> Galleries { get; set; }
        //public DbSet<ClaudeAIMessage> ClaudeAIMessages { get; set; }
        //public DbSet<Revenue> Revenues { get; set; }
        //public DbSet<Expense> Expenses { get; set; }
        //public DbSet<Policy> Policies { get; set; }

    }
}

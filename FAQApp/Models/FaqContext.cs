using Microsoft.EntityFrameworkCore;

namespace FAQApp.Models
{
    public class FaqContext : DbContext
    {
        public FaqContext(DbContextOptions<FaqContext> options)
            : base(options)
        {
        }

        public DbSet<Faq> Faqs { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>().HasData(
                new Topic { Id = "general", Name = "General" },
                new Topic { Id = "account", Name = "Account" },
                new Topic { Id = "billing", Name = "Billing" }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = "product", Name = "Product" },
                new Category { Id = "service", Name = "Service" },
                new Category { Id = "policy", Name = "Policy" }
            );

            modelBuilder.Entity<Faq>().HasData(
                            new Faq
                            {
                                Id = 1,
                                Question = "How intellegent are Retreivers?",
                                Answer = "They are very intelligent..",
                                TopicId = "Retriever",
                                CategoryId = "General"
                            },
                            new Faq
                            {
                                Id = 2,
                                Question = "How do I maintain my Retriever?",
                                Answer = "Regular grooming and vet check-ups are essential...",
                                TopicId = "Retriever",
                                CategoryId = "Maintenance"
                            },
                            new Faq
                            {
                                Id = 3,
                                Question = "What is the history of the Retriever breed?",
                                Answer = "Retrievers were originally bred as hunting dogs...",
                                TopicId = "Retriever",
                                CategoryId = "History"
                            },
                            new Faq
                            {
                                Id = 4,
                                Question = "How big do Chihuahuas get?",
                                Answer = "Chihuahuas typically weigh between 2-6 pounds...",
                                TopicId = "Chihuahua",
                                CategoryId = "General"
                            },
                            new Faq
                            {
                                Id = 5,
                                Question = "How often should I feed my Chihuahua?",
                                Answer = "Adult Chihuahuas should be fed 2-3 times a day...",
                                TopicId = "Chihuahua",
                                CategoryId = "Maintenance"
                            },
                            new Faq
                            {
                                Id = 6,
                                Question = "What is the origin of the Chihuahua breed?",
                                Answer = "Chihuahuas are believed to have originated in Mexico...",
                                TopicId = "Chihuahua",
                                CategoryId = "History"
                            },
                            new Faq
                            {
                                Id = 7,
                                Question = "Are Pomeranians good with kids?",
                                Answer = "Pomeranians can be good with kids if socialized early...",
                                TopicId = "Pomeranian",
                                CategoryId = "General"
                            },
                            new Faq
                            {
                                Id = 8,
                                Question = "How do I groom my Pomeranian?",
                                Answer = "Regular brushing and occasional baths are recommended...",
                                TopicId = "Pomeranian",
                                CategoryId = "Maintenance"
                            },
                            new Faq
                            {
                                Id = 9,
                                Question = "What is the history of the Pomeranian breed?",
                                Answer = "Pomeranians are descended from large sled dogs...",
                                TopicId = "Pomeranian",
                                CategoryId = "History"
                            }
                        );
        }
    }
}

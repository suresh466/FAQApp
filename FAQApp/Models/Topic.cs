namespace FAQApp.Models
{
    public class Topic
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<Faq> Faqs { get; set; }
    }

}

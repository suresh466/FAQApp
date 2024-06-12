namespace FAQApp.Models
{
    public class FaqViewModel
    {
        public IEnumerable<Faq> Faqs { get; set; }
        public IEnumerable<Topic> Topics { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public string CurrentTopicId { get; set; }
        public string CurrentCategoryId { get; set; }
    }
}

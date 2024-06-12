using FAQApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FAQApp.Controllers
{
    public class FaqsController : Controller
    {
        private readonly FaqContext _context;

        public FaqsController(FaqContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string topicId = null, string categoryId = null)
        {
            IQueryable<Faq> faqs = _context.Faqs
                .Include(f => f.Topic)
                .Include(f => f.Category);

            if (!string.IsNullOrEmpty(topicId))
            {
                faqs = faqs.Where(f => f.TopicId == topicId);
            }

            if (!string.IsNullOrEmpty(categoryId))
            {
                faqs = faqs.Where(f => f.CategoryId == categoryId);
            }

            var topics = await _context.Topics.ToListAsync();
            var categories = await _context.Categories.ToListAsync();

            var viewModel = new FaqViewModel
            {
                Faqs = await faqs.ToListAsync(),
                Topics = topics,
                Categories = categories,
                CurrentTopicId = topicId,
                CurrentCategoryId = categoryId
            };

            return View(viewModel);
        }
    }
}

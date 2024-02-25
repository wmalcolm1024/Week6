using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab5.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }


        public string? Message { get; set; }
        public void OnGet()
        {
            Message = $"Hello World The Time Is: {DateTime.Now.ToLongTimeString()}";
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;


namespace ASPCoreHomework3_1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }


        [BindProperty]
        public int x { get; set; }
        [BindProperty]
        public int y { get; set; }
      
        public int result { get; set; }

        public void OnGet()
        {
            
        }

        public void OnPostAdd()
        {
            result = x + y;
        }

        public void OnPostSub()
        {
            result = x - y;
        }

        public void OnPostMul()
        {
            result = x * y;
        }
        public void OnPostDiv()
        {
            result = x / (y == 0 ? 1 : y);
        }


    }
}

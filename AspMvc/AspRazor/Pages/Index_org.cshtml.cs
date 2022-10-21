using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspRazor.Pages
{
    public class IndexModel_Org : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel_Org(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
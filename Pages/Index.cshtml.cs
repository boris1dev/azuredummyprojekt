using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace azure_boris_erste_web_app.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private IConfiguration _c;

    public IndexModel(ILogger<IndexModel> logger, IConfiguration c)
    {
        _logger = logger;
        _c = c;
    }

    public void OnGet()
    {
        ViewData["greetings"] = _c["Greetings"];
    }
}

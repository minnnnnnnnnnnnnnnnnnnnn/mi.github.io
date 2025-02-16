using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace 臺中市立臺中第一高級中等學校學生自治聯合會法規資料庫.Pages;

public class OpenModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public OpenModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}


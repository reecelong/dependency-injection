using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DependencyInjection.Pages
{
    #region snippet
    public class AboutModel : PageModel
    {
        private readonly ILogger _logger;

        public AboutModel(ILogger<AboutModel> logger)
        {
            _logger = logger;
        }
        
        public string Message { get; set; } = string.Empty;

        public void OnGet()
        {
            Message = $"About page visited at {DateTime.UtcNow.ToLongTimeString()}";
            _logger.LogInformation(Message);
        }
    }
    #endregion
}

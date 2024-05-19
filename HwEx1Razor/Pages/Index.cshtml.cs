using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HwEx1Razor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private string _letterString => "ABCDEFGHIKLMNOPQRSTVXYZ";
        public char RandomLetter { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            RandomLetter = _letterString[new Random().Next(0, _letterString.Length-1)];
        }
    }
}

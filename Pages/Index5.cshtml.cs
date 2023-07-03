using DependencyInjection.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DependencyInjection.Pages
{
    public class Index5Model : PageModel
    {
        private readonly IMyDependency _myDependency;

        public Index5Model(IMyDependency myDependency)
        {
            _myDependency = myDependency;            
        }

        public void OnGet()
        {
            _myDependency.WriteMessage("IndexModel.OnGetAsync");
        }
    }
}

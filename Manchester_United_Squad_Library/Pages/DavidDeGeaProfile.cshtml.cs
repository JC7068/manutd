using Manchester_United_Squad_Library.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Manchester_United_Squad_Library.Pages
{
    public class DavidDeGeaProfileModel : PageModel
    {
        private readonly ApplicationDbContext Context;
        public DavidDeGeaProfileModel(ApplicationDbContext context) 
        {
            Context = context;
        }

        public void OnGet()
        {
            Console.WriteLine(Context);
        }
    }
}

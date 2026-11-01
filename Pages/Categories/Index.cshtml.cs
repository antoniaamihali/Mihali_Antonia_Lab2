using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mihali_Antonia_Lab2.Models;

namespace Mihali_Antonia_Lab2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Mihali_Antonia_Lab2Context _context;

        public IndexModel(Mihali_Antonia_Lab2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}

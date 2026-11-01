using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mihali_Antonia_Lab2.Models;

namespace Mihali_Antonia_Lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Mihali_Antonia_Lab2Context _context;

        public IndexModel(Mihali_Antonia_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
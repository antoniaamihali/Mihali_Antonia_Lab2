using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mihali_Antonia_Lab2.Models;

namespace Mihali_Antonia_Lab2.Pages.Borrowings
{
    public class IndexModel : PageModel
    {
        private readonly Mihali_Antonia_Lab2Context _context;

        public IndexModel(Mihali_Antonia_Lab2Context context)
        {
            _context = context;
        }

        public IList<Borrowing> Borrowing { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Borrowing != null)
            {
                Borrowing = await _context.Borrowing
                    .Include(b => b.Book)
                        .ThenInclude(b => b.Author)
                    .Include(b => b.Member)
                    .ToListAsync();
            }
        }
    }
}
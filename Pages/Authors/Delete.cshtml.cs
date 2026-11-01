using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mihali_Antonia_Lab2.Models;

namespace Mihali_Antonia_Lab2.Pages.Authors
{
    public class DeleteModel : PageModel
    {
        private readonly Mihali_Antonia_Lab2Context _context;

        public DeleteModel(Mihali_Antonia_Lab2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Author Author { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var author = await _context.Author.FirstOrDefaultAsync(m => m.ID == id);
            if (author == null)
            {
                return NotFound();
            }
            Author = author;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var author = await _context.Author.FindAsync(Author.ID);
            if (author != null)
            {
                _context.Author.Remove(author);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
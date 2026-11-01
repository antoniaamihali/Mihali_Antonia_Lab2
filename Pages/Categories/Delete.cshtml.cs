using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mihali_Antonia_Lab2.Models;

namespace Mihali_Antonia_Lab2.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        private readonly Mihali_Antonia_Lab2Context _context;

        public DeleteModel(Mihali_Antonia_Lab2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Category Category { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);
            if (category == null)
            {
                return NotFound();
            }
            Category = category;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var category = await _context.Category.FindAsync(Category.ID);
            if (category != null)
            {
                _context.Category.Remove(category);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
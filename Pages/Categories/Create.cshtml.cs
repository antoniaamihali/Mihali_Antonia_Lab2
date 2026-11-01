using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mihali_Antonia_Lab2.Models;

namespace Mihali_Antonia_Lab2.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Mihali_Antonia_Lab2Context _context;

        public CreateModel(Mihali_Antonia_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
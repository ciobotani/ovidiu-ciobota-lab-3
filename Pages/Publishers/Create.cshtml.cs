using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ovidiu_ciobota_lab_3.Data;
using ovidiu_ciobota_lab_3.Models;

namespace ovidiu_ciobota_lab_3.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly ovidiu_ciobota_lab_3.Data.ovidiu_ciobota_lab_3Context _context;

        public CreateModel(ovidiu_ciobota_lab_3.Data.ovidiu_ciobota_lab_3Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

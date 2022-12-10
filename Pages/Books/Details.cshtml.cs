using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ovidiu_ciobota_lab_3.Data;
using ovidiu_ciobota_lab_3.Models;

namespace ovidiu_ciobota_lab_3.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly ovidiu_ciobota_lab_3.Data.ovidiu_ciobota_lab_3Context _context;

        public DetailsModel(ovidiu_ciobota_lab_3.Data.ovidiu_ciobota_lab_3Context context)
        {
            _context = context;
        }

      public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;
            }
            return Page();
        }
    }
}

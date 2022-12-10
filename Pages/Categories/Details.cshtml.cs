using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ovidiu_ciobota_lab_3.Data;
using ovidiu_ciobota_lab_3.Models;

namespace ovidiu_ciobota_lab_3.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly ovidiu_ciobota_lab_3.Data.ovidiu_ciobota_lab_3Context _context;

        public DetailsModel(ovidiu_ciobota_lab_3.Data.ovidiu_ciobota_lab_3Context context)
        {
            _context = context;
        }

      public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);
            if (category == null)
            {
                return NotFound();
            }
            else 
            {
                Category = category;
            }
            return Page();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ovidiu_ciobota_lab_3.Data;
using ovidiu_ciobota_lab_3.Models;

namespace ovidiu_ciobota_lab_3.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly ovidiu_ciobota_lab_3.Data.ovidiu_ciobota_lab_3Context _context;

        public DetailsModel(ovidiu_ciobota_lab_3.Data.ovidiu_ciobota_lab_3Context context)
        {
            _context = context;
        }

      public Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Publisher == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);
            if (publisher == null)
            {
                return NotFound();
            }
            else 
            {
                Publisher = publisher;
            }
            return Page();
        }
    }
}

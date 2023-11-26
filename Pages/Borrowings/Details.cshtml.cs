using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Konya_Zoltan_Lab22.Data;
using Konya_Zoltan_Lab22.Models;

namespace Konya_Zoltan_Lab22.Pages.Borrowings
{
    public class DetailsModel : PageModel
    {
        private readonly Konya_Zoltan_Lab22.Data.Konya_Zoltan_Lab22Context _context;

        public DetailsModel(Konya_Zoltan_Lab22.Data.Konya_Zoltan_Lab22Context context)
        {
            _context = context;
        }

      public Borrowing Borrowing { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Borrowing == null)
            {
                return NotFound();
            }

            var borrowing = await _context.Borrowing.FirstOrDefaultAsync(m => m.ID == id);
            if (borrowing == null)
            {
                return NotFound();
            }
            else 
            {
                Borrowing = borrowing;
            }
            return Page();
        }
    }
}

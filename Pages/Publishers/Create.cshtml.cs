﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Konya_Zoltan_Lab22.Data;
using Konya_Zoltan_Lab22.Models;

namespace Konya_Zoltan_Lab22.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Konya_Zoltan_Lab22.Data.Konya_Zoltan_Lab22Context _context;

        public CreateModel(Konya_Zoltan_Lab22.Data.Konya_Zoltan_Lab22Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Publisher == null || Publisher == null)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

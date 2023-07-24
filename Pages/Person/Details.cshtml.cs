using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using azure_boris_erste_web_app.Data;

namespace azure_boris_erste_web_app.Pages.Person
{
    public class DetailsModel : PageModel
    {
        private readonly azure_boris_erste_web_app.Data.AppDbContext _context;

        public DetailsModel(azure_boris_erste_web_app.Data.AppDbContext context)
        {
            _context = context;
        }

      public Data.Person Person { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Persons == null)
            {
                return NotFound();
            }

            var person = await _context.Persons.FirstOrDefaultAsync(m => m.Id == id);
            if (person == null)
            {
                return NotFound();
            }
            else 
            {
                Person = person;
            }
            return Page();
        }
    }
}

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
    public class IndexModel : PageModel
    {
        private readonly azure_boris_erste_web_app.Data.AppDbContext _context;

        public IndexModel(azure_boris_erste_web_app.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Data.Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Persons != null)
            {
                Person = await _context.Persons.ToListAsync();
            }
        }
    }
}

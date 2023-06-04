using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages_Scripture
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMovie.Data.RazorPagesMovieContext _context;

        public DetailsModel(RazorPagesMovie.Data.RazorPagesMovieContext context)
        {
            _context = context;
        }

      public Scripture Scripture { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
                if (id == null)
                {
                    return NotFound();
                }
            if (id == null || _context.Scripture == null)
            {
                return NotFound();
            }

            var movie = await _context.Scripture.FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            else 
            {
                Scripture = movie;
            }
            return Page();
        }
    }
}

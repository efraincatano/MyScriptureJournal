using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages_Scripture
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie.Data.RazorPagesMovieContext _context;

        public IndexModel(RazorPagesMovie.Data.RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get;set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string ? SearchString { get; set; }
        public SelectList ? Book { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ? ScriptureBook { get; set; }

public async Task OnGetAsync()
{
    // Use LINQ to get list of genres.
    IQueryable<string> genreQuery = from m in _context.Scripture
                                    orderby m.Book
                                    select m.Book;

    var scriptures = from m in _context.Scripture
                 select m;

    if (!string.IsNullOrEmpty(SearchString))
    {
        scriptures = scriptures.Where(s => s.Notes.Contains(SearchString));
    }

    if (!string.IsNullOrEmpty(ScriptureBook))
    {
        scriptures = scriptures.Where(x => x.Book == ScriptureBook);
    }
    Book = new SelectList(await genreQuery.Distinct().ToListAsync());
    Scripture = await scriptures.ToListAsync();
}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorApp.Data;
using RazorApp.Models;

namespace RazorApp.Pages_Workouts
{
    public class IndexModel : PageModel
    {
        private readonly RazorApp.Data.RazorAppContext _context;

        public IndexModel(RazorApp.Data.RazorAppContext context)
        {
            _context = context;
        }

        public IList<Workout> Workout { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Workout = await _context.Workout.ToListAsync();
        }
    }
}

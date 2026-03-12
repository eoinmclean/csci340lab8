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
    public class DetailsModel : PageModel
    {
        private readonly RazorApp.Data.RazorAppContext _context;

        public DetailsModel(RazorApp.Data.RazorAppContext context)
        {
            _context = context;
        }

        public Workout Workout { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workout = await _context.Workout.FirstOrDefaultAsync(m => m.Id == id);

            if (workout is not null)
            {
                Workout = workout;

                return Page();
            }

            return NotFound();
        }
    }
}

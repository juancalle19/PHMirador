using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PHMirador.API.Data;
using PHMirador.Shared.Entities;

namespace PHMirador.API.Controllers
{
    [ApiController]
    [Route("/api/meetings")]
    public class MeetingsController : ControllerBase
    {
        private readonly DataContext _context;

        public MeetingsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            return Ok(await _context.Meetings.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync(Meeting meeting)
        {
            _context.Add(meeting);
            await _context.SaveChangesAsync();
            return Ok(meeting);
        }


    }
}

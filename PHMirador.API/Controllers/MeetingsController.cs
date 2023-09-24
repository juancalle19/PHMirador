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

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetAsync(int id)
        {
            var meeting = await _context.Meetings.FirstOrDefaultAsync(x => x.Id == id);
            if (meeting == null)
            {
                return NotFound();
            }
            return Ok(meeting);
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync(Meeting meeting)
        {
            _context.Add(meeting);
            await _context.SaveChangesAsync();
            return Ok(meeting);
        }

        [HttpPut]
        public async Task<ActionResult> PutAsync(Meeting meeting)
        {
            _context.Update(meeting);
            await _context.SaveChangesAsync();
            return Ok(meeting);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var meeting = await _context.Meetings.FirstOrDefaultAsync(x => x.Id == id);
            if (meeting == null)
            {
                return NotFound();
            }
            _context.Remove(meeting);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DidAPI.Models;

namespace DidAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MissionController : ControllerBase
    {
        private readonly DataContext _context ;


        public MissionController(DataContext context)
        {
            _context = context;
                
        }
        [HttpGet]
        public async Task<ActionResult<List<Mission>>> Get()
        {
            return Ok(await _context.Missions.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Mission>>  Get(int id)
        {
            var missi = await _context.Missions.FindAsync(id);
            if (missi == null)
                return BadRequest("No such Missions.");
            return Ok(missi);
        }
        [HttpPost]
        public async Task<ActionResult<List<Mission>>> AddMission(Mission missi)
        {
            _context.Missions.Add(missi);
            await _context.SaveChangesAsync();

            return Ok(await _context.Missions.ToListAsync());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Mission>>> Put(int id, Mission request)
        {
            var dbMissi = await _context.Missions.FindAsync(id);
            if (dbMissi == null)
                return BadRequest("Mission not found.");

            dbMissi.Title = request.Title;
            dbMissi.Deadline = request.Deadline;
            dbMissi.Description = request.Description;
            dbMissi.Checkbox = request.Checkbox;
            

            await _context.SaveChangesAsync();

            return Ok(await _context.Missions.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Mission>>> Delete(int id)
        {
            var dbMissi = await _context.Missions.FindAsync(id);
            if (dbMissi == null)
                return BadRequest("Mission not found.");

            _context.Missions.Remove(dbMissi);
            await _context.SaveChangesAsync();

            return Ok(await _context.Missions.ToListAsync());
        }
    }
}

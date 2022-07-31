using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RocketElevators.Data;
using RocketElevators.Models;

namespace Rocket_Rest_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterventionsController : ControllerBase
    {
        private readonly RocketElevatorsContext _context;

        public InterventionsController(RocketElevatorsContext context)
        {
            _context = context;
        }

        // GET: api/Interventions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Intervention>>> GetInterventions()
        {
          if (_context.Interventions == null)
          {
              return NotFound();
          }
            return await _context.Interventions.ToListAsync();
        }

        // GET: api/Interventions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Intervention>> GetIntervention(long id)
        {
          if (_context.Interventions == null)
          {
              return NotFound();
          }
            var intervention = await _context.Interventions.FindAsync(id);

            if (intervention == null)
            {
                return NotFound();
            }

            return intervention;
        }

        [HttpGet("status")]
        public async Task<ActionResult<IEnumerable<Intervention>>> GetInterventionStatuss()
        {
            var interventions = await _context.Interventions.ToListAsync();
            var interventionList = new List<Intervention>(){};

            foreach (Intervention intervention in interventions)
            {
                if (intervention.InterventionDateStart == "0" && intervention.Status == "pending")
                {
                    interventionList.Add(intervention);
                }
            }

            return interventionList;
        }


        [HttpGet("{id}/inProgress")]
        public async Task<ActionResult<Intervention>> SetInterventionInProgress(long id)
        {
            var intervention = await _context.Interventions.FindAsync(id);

            if (intervention == null)
            {
                return NotFound();
            }
            var date = DateTime.Now;

            intervention.InterventionDateStart = date.ToString();
            intervention.Status = "InProgress";

            _context.Interventions.Update(intervention);
            _context.SaveChanges();





            return intervention;
        }

        [HttpGet("{id}/completed")]
        public async Task<ActionResult<Intervention>> SetInterventionCompleted(long id)
        {
            var intervention = await _context.Interventions.FindAsync(id);
            if (intervention == null)
            {
                return NotFound();
            }

            var date = DateTime.Now;

            intervention.InterventionDateEnd = date.ToString();
            intervention.Status = "Completed";

            _context.Interventions.Update(intervention);
            _context.SaveChanges();

            return intervention;
        }




        // PUT: api/Interventions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIntervention(long id, Intervention intervention)
        {
            if (id != intervention.Id)
            {
                return BadRequest();
            }

            _context.Entry(intervention).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InterventionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Interventions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Intervention>> PostIntervention(Intervention intervention)
        {
          if (_context.Interventions == null)
          {
              return Problem("Entity set 'RocketElevatorsContext.Interventions'  is null.");
          }
            _context.Interventions.Add(intervention);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIntervention", new { id = intervention.Id }, intervention);
        }

        // DELETE: api/Interventions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIntervention(long id)
        {
            if (_context.Interventions == null)
            {
                return NotFound();
            }
            var intervention = await _context.Interventions.FindAsync(id);
            if (intervention == null)
            {
                return NotFound();
            }

            _context.Interventions.Remove(intervention);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InterventionExists(long id)
        {
            return (_context.Interventions?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

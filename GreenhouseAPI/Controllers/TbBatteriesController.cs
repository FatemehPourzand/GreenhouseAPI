using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GreenhouseAPI.Data;
using GreenhouseAPI.Dto.TbBatteries;
using GreenhouseAPI.Configurations;
using AutoMapper;
using GreenhouseAPI.Dto.TbBatteriess;

namespace GreenhouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TbBatteriesController : ControllerBase
    {
        private readonly DBGreenhouseNGContext _context;
        private readonly IMapper mapper;

        public TbBatteriesController(DBGreenhouseNGContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        // GET: api/TbBatteries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbBatteriesReadOnlyDto>>> GetTbBatteries()
        {

            var tbBattey = await _context.TbBatteries.ToListAsync();
            var tbBatteriesDtos = mapper.Map<IEnumerable<TbBatteriesReadOnlyDto>>(tbBattey);
            return Ok(tbBatteriesDtos);

        }

        // GET: api/TbBatteries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbBatteriesReadOnlyDto>> GetTbBattery(int id)
        {
            var tbBattery = await _context.TbUsers.FindAsync(id);

            if (_context.TbBatteries == null)
            {
                return NotFound();
            }

            var tbBatteryDto = await _context.TbBatteries.FindAsync(id);
            return Ok(tbBatteryDto);
        }

        // PUT: api/TbBatteries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbBattery(int id, TbBatteriesUpdateDto tbBatteryDto)
        {

            {
                if (id != tbBatteryDto.Id)
                {
                    return BadRequest();
                }

                var tbBattery = await _context.TbBatteries.FindAsync(id);

                if (tbBattery == null)
                {
                    return NotFound();
                }

                mapper.Map(tbBatteryDto, tbBattery);
                _context.Entry(tbBattery).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {

                    if (!TbBatteryExists(id))
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
        }

        // POST: api/TbBatteries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TbBattery>> PostTbBattery(TbBatteriesReadOnlyDto tbBatteryDto)
        {
            var tbBatteries = mapper.Map<TbBattery>(tbBatteryDto);
            await _context.TbBatteries.AddAsync(tbBatteries);
            await _context.SaveChangesAsync();

            string state;
            if (tbBatteryDto.Voltage >= 10)
            {
                state = "Full Charged";
            }
            else if (tbBatteryDto.Voltage > 0 && tbBatteryDto.Voltage < 10)
            {
                state = "Weak";

            }
            else 
            {
                state = "Empty";

            }

            return new ObjectResult(new
            {
                code = 200,
                message = "OK",
                body = new { FullName = state }


            });

            

        }

        // DELETE: api/TbBatteries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTbBattery(int id)
        {
            if (_context.TbBatteries == null)
            {
                return NotFound();
            }
            var tbBattery = await _context.TbBatteries.FindAsync(id);
            if (tbBattery == null)
            {
                return NotFound();
            }

            _context.TbBatteries.Remove(tbBattery);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TbBatteryExists(int id)
        {
            return (_context.TbBatteries?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

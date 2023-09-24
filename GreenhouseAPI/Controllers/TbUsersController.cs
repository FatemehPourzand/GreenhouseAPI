using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GreenhouseAPI.Data;
using AutoMapper;
using GreenhouseAPI.Dto.TbBatteries;
using GreenhouseAPI.Dto.TbBatteriess;

namespace GreenhouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TbUsersController : ControllerBase
    {
        private readonly DBGreenhouseNGContext _context;
        private readonly IMapper mapper;

        public TbUsersController(DBGreenhouseNGContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        // GET: api/TbUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbUserReadOnlyDto>>> GetTbUsers()
        {
            var tbUsers = await _context.TbUsers.ToListAsync();
            var tbUserDtos = mapper.Map<IEnumerable<TbUserReadOnlyDto>>(tbUsers);
            return Ok(tbUserDtos);
        }

        // GET: api/TbUsers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbUserReadOnlyDto>> GetAuthor(int id)
        {
            var tbUser = await _context.TbUsers.FindAsync(id);

            if (_context.TbUsers == null)
            {
                return NotFound();
            }

            var tbUserDto = await _context.TbUsers.FindAsync(id);
            return Ok(tbUserDto);
        }

        // PUT: api/TbUsers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbUser(int id, TbUserUpdateDto tbUserDto)
        {
            if (id != tbUserDto.IdUser)
            {
                return BadRequest();
            }

            var tbUser = await _context.TbUsers.FindAsync(id);

            if (tbUser == null)
            {
                return NotFound();
            }

            mapper.Map(tbUserDto, tbUser);
            _context.Entry(tbUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ATbUserExists(id))
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

        // POST: api/TbUsers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TbUserCreateDto>> PostTbUser(TbUserCreateDto tbUserDto)
        {
            var tbUser = mapper.Map<TbUser>(tbUserDto);
            await _context.TbUsers.AddAsync(tbUser);
            await _context.SaveChangesAsync();

            return Ok();

        }

        // DELETE: api/TbUsers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTbUser(int id)
        {
            if (_context.TbUsers == null)
            {
                return NotFound();
            }
            var tbUser = await _context.TbUsers.FindAsync(id);
            if (tbUser == null)
            {
                return NotFound();
            }

            _context.TbUsers.Remove(tbUser);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private async Task<bool> ATbUserExists(int id)
        {
            return (_context.TbUsers?.Any(e => e.IdUser == id)).GetValueOrDefault();
        }
    }
}

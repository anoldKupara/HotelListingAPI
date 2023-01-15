using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HotelListing.API.Data;
using HotelListing.API.Models;
using HotelListing.API.DTOs.Countries;
using AutoMapper;

namespace HotelListing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly HotelListingDbContext _dBcontext;
        private readonly IMapper _mapper;

        public CountriesController(HotelListingDbContext dBcontext, IMapper mapper)
        {
            _dBcontext = dBcontext;
            _mapper = mapper;
        }

        // GET: api/Countries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Country>>> GetCountries()
        {
            return await _dBcontext.Countries.ToListAsync();
        }

        // GET: api/Countries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Country>> GetCountry(int id)
        {
            var country = await _dBcontext.Countries.FindAsync(id);

            if (country == null)
            {
                return NotFound();
            }

            return country;
        }

        // PUT: api/Countries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCountry(int id, Country country)
        {
            if (id != country.Id)
            {
                return BadRequest();
            }

            _dBcontext.Entry(country).State = EntityState.Modified;

            try
            {
                await _dBcontext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CountryExists(id))
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

        // POST: api/Countries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Country>> PostCountry(CreateCountryDto createCountryDto)
        {
            //var country = new Country
            //{
            //    Name = createCountryDto.Name,
            //    ShortName = createCountryDto.ShortName
            //};
            var country = _mapper.Map<Country>(createCountryDto);
            _dBcontext.Countries.Add(country);
            await _dBcontext.SaveChangesAsync();

            return CreatedAtAction("GetCountry", new { id = country.Id }, country);
        }

        // DELETE: api/Countries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCountry(int id)
        {
            var country = await _dBcontext.Countries.FindAsync(id);
            if (country == null)
            {
                return NotFound();
            }

            _dBcontext.Countries.Remove(country);
            await _dBcontext.SaveChangesAsync();

            return NoContent();
        }

        private bool CountryExists(int id)
        {
            return _dBcontext.Countries.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Hero.Data;
using Hero.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Hero.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly DataContext _context;

        public SuperHeroController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes(){
            var heroes = await _context.SuperHeroes.ToListAsync();

            return Ok(heroes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetHeroe(int id){
            var hero = await _context.SuperHeroes.FindAsync(id);
            if(hero is null)
                return NotFound("Hero not found");
            
            return Ok(hero);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHeroe(SuperHero hero){
            _context.SuperHeroes.Add(hero);
            await _context.SaveChangesAsync();

            return Ok(hero);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<SuperHero>> UpdateHeroe(SuperHero updatedhero, int id){
            var dbHero = await _context.SuperHeroes.FindAsync(id);
            if(dbHero is null)
                return NotFound("Hero not found");
            else
                dbHero.Name = updatedhero.Name;
                dbHero.FirstName = updatedhero.FirstName;
                dbHero.LastName = updatedhero.LastName;
                dbHero.Place = updatedhero.Place;

                await _context.SaveChangesAsync();

            return Ok(updatedhero);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHero>>> DeleteHeroe(int id){
            var hero = await _context.SuperHeroes.FindAsync(id);
            if(hero is null)
                return NotFound("Hero not found");

            _context.SuperHeroes.Remove(hero);
            await _context.SaveChangesAsync();
            var heroes = await _context.SuperHeroes.ToListAsync();

            
            return Ok(heroes);
        }
   }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Data;
//using WebApp.Data;
using WebApp.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PixelPlacementController : ControllerBase
    {

        private MemoryRepository repository;

        public PixelPlacementController()
        {
            repository = MemoryRepository.GetInstance();
        }

        // GET: api/<PixelPlacementController>
        [HttpGet]
        public IEnumerable<PixelPlacement> Get()
        {
            return repository.PixelPlacements;
        }

        // GET api/<PixelPlacementController>/5
        [HttpGet("{id}")]
        public PixelPlacement Get(int id)
        {
            return repository[id];
        }

        // POST api/<PixelPlacementController>
        [HttpPost]
        [ProducesResponseType(400)]
        [ProducesResponseType(201)]
        public ActionResult<PixelPlacement> Post(PixelPlacementDto placement)
        {
            if (placement == null)
            {
                return BadRequest();
            }

            var newPlacement = repository.AddPixelPlacement(new PixelPlacement
            {
                X = placement.x,
                Y = placement.y
            });
            return CreatedAtAction("Get", new { id = newPlacement.PixelPlacementID }, newPlacement);
        }

        // PUT api/<PixelPlacementController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PixelPlacementController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
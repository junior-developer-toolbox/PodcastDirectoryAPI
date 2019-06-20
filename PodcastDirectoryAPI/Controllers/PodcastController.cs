using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PodcastDirectoryAPI.Data;
using PodcastDirectoryAPI.Domain;

namespace PodcastDirectoryAPI.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class PodcastController : ControllerBase
    {
        private readonly PodcastDirectoryAPIContext _context;
        public PodcastController(PodcastDirectoryAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetPodcasts()
        {
            return Ok(_context.PodcastDetails.ToList());
        }

        [HttpPost]
        public async Task<IActionResult> AddPodcastDetails([FromBody] PodcastDetails objPodcast)
        {
            if (!ModelState.IsValid)
            {
                return new JsonResult("Error while creating podcast");
            }
            _context.PodcastDetails.Add(objPodcast);
            await _context.SaveChangesAsync();

            return new JsonResult("Podcast created successfully.");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePodcastDetails([FromRoute] int id, [FromBody] PodcastDetails objPodcast)
        {
            if (objPodcast == null || id != objPodcast.PodcastID)
            {
                return new JsonResult("Podcast was not found.");
            }
            else
            {
                _context.PodcastDetails.Update(objPodcast);
                await _context.SaveChangesAsync();
                return new JsonResult("Podcast updated successfully.");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePodcastDetails([FromRoute] int id)
        {
            var findPodcastDetails = await _context.PodcastDetails.FindAsync(id);
            if (findPodcastDetails == null)
            {
                return NotFound();
            }
            else
            {
                _context.PodcastDetails.Remove(findPodcastDetails);
                await _context.SaveChangesAsync();
                return new JsonResult("Podcast deleted successfully.");
            }
        }
    }
}

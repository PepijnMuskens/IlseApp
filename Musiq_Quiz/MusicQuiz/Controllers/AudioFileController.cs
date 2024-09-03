using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicQuiz.Data;
using MusicQuiz.Data.Models;
using MusicQuiz.DTOs;

namespace MusicQuiz.Controllers
{
    [ApiController]
    public class AudioFileController : ControllerBase
    {
        private readonly MusicQuizDBContext _context;

        public AudioFileController(MusicQuizDBContext context)
        {
            _context = context;
        }

        [HttpGet("audiofiles")]
        public async Task<ActionResult<IEnumerable<AudioFile>>> GetAudioFiles()
        {
            return await _context.AudioFiles.ToListAsync();
        }

        [HttpGet("audiofiles/{id}")]
        public async Task<ActionResult<AudioFile>> GetAudioFile(int id)
        {
            var audioFile = await _context.AudioFiles.FindAsync(id);

            if (audioFile == null)
            {
                return NotFound();
            }

            return audioFile;
        }

        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("audiofiles/{id}")]
        public async Task<IActionResult> PutAudioFile(int id, AudioFile audioFile)
        {
            if (id != audioFile.Id)
            {
                return BadRequest();
            }

            _context.Entry(audioFile).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AudioFileExists(id))
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

        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("audiofiles")]
        public async Task<ActionResult<AudioFile>> PostAudioFile(AudioFileDTO audioFileDTO)
        {
            var audioFile = new AudioFile
            {
                Name = audioFileDTO.Name,
                AudioData = audioFileDTO.AudioData
            };

            _context.AudioFiles.Add(audioFile);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAudioFile", new { id = audioFile.Id }, audioFile);
        }

        [HttpDelete("audiofiles/{id}")]
        public async Task<IActionResult> DeleteAudioFile(int id)
        {
            var audioFile = await _context.AudioFiles.FindAsync(id);
            if (audioFile == null)
            {
                return NotFound();
            }

            _context.AudioFiles.Remove(audioFile);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AudioFileExists(int id)
        {
            return _context.AudioFiles.Any(e => e.Id == id);
        }
    }
}

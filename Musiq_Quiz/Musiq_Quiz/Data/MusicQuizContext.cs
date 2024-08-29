using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicQuiz.Models;

namespace MusicQuiz.Data
{
    public class MusicQuizContext : DbContext
    {
        public MusicQuizContext (DbContextOptions<MusicQuizContext> options)
            : base(options)
        {
        }

        public DbSet<MusicQuiz.Models.AudioFile> AudioFile { get; set; } = default!;
    }
}

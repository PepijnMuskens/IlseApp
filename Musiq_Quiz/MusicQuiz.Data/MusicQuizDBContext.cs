using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicQuiz.Data.Models;


namespace MusicQuiz.Data;

public class MusicQuizDBContext : DbContext
{
    public MusicQuizDBContext(DbContextOptions<MusicQuizDBContext> options)
            : base(options)
    {
    }

    public DbSet<AudioFile> AudioFiles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySQL("server=1j6.h.filess.io;user=MusicQuiz_fliesfast;database=MusicQuiz_fliesfast;port=3307;password=31762c70cd035dd1f9dcce97a658a33d91741055");
        }
    }
}

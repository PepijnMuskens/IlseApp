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
    public DbSet<AudioFile> AudioFiles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySQL("Server=1j6.h.filess.io;Database=Music_Quiz;User Id=MusicQuiz_fliesfast;Password=31762c70cd035dd1f9dcce97a658a33d91741055;");
        }
    }
}

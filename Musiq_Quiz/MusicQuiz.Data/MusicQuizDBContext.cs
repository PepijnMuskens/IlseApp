﻿using System;
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
            optionsBuilder.UseNpgsql("Host=music-quiz-11117.7tc.aws-eu-central-1.cockroachlabs.cloud;Port=26257;Username=juicybram;Password=kHS2didnYbXrEUj97vMuYQ;Database=defaultdb;SslMode=Require");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DSED03
{
    public class ScoreContext : DbContext
    {
        public DbSet<Score> Scores { get; set; }

        private string DatabasePath { get; set; }

        public ScoreContext() { }

        public ScoreContext(string databasePath)
        {
            DatabasePath = databasePath;
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DatabasePath}");
        }


    }

    public class Score
    {
        [Key]
        public int ScoreId { get; set; }

        public string Word { get; set; }

        public int Value { get; set; }
    }


}
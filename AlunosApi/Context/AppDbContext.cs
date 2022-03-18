﻿using AlunosApi.Models;
using Microsoft.EntityFrameworkCore;


namespace AlunosApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().HasData(
                new Aluno
                {
                    Id = 1,
                    Nome = "Saulo Marcos",
                    Email = "saulomarcos@hotmail.com",
                    Idade = 28
                },
                new Aluno
                {
                    Id = 2,
                    Nome = "Maurilio Lucena",
                    Email = "mauriliolucena@hotmail.com",
                    Idade = 32
                }
             );
        }
    }
}

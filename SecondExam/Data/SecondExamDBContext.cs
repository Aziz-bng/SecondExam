using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SecondExam.Models;

namespace SecondExam.Data
{
    public class SecondExamDBContext : DbContext
    {
        public SecondExamDBContext (DbContextOptions<SecondExamDBContext> options)
            : base(options)
        {
        }

        public DbSet<SecondExam.Models.Exam> Exam { get; set; } = default!;
        public DbSet<SecondExam.Models.Question> Question { get; set; } = default!;
        public DbSet<SecondExam.Models.Answer> Answer { get; set; } = default!;
    }
}

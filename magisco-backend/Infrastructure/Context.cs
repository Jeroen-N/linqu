using Magisco.Profile.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Magisco.Profile.Infrastructure
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        { }

        public DbSet<QuestionSet> QuestionSets { get; set; }
        public DbSet<AnswerSet> AnswerSets { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
    }
}

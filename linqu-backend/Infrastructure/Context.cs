using linqu.profileservice.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace linqu.profileservice.Infrastructure
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        { }

        public DbSet<QuestionSet> QuestionSets { get; set; }
        public DbSet<AnswerSet> AnswerSets { get; set; }
    }
}

using Magisco.Profile.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Magisco.Profile.Models;
using Magisco.Profile.Infrastructure;

namespace Magisco.Profile.Services
{
    public class AnswerService : IAnswerService
    {

        public Context _context;

        public AnswerService(Context context)
        {
            _context = context;
        }

        public void CreateAnswer(Answer answer)
        {
            _context.Answers.Add(answer);
            _context.SaveChanges();
        }

        public void CreateAnswerSet(AnswerSet answerSet)
        {

            _context.AnswerSets.Add(answerSet);
            _context.SaveChanges();
        }

        public void DeleteAnswer(Guid answerID)
        {
            _context.Answers.Remove(_context.Answers.Single(x => x.AnswerID == answerID));
            _context.SaveChanges();
        }

        public void DeleteAnswerSet(Guid answerSetID)
        {
            _context.AnswerSets.Remove(_context.AnswerSets.Single(x => x.AnswerSetID == answerSetID));
            _context.SaveChanges();
        }

        public IEnumerable<Answer> GetAllAnswers()
        {
            return _context.Answers;
        }

        public IEnumerable<AnswerSet> GetAllAnswerSets()
        {
            return _context.AnswerSets;
        }

        public Answer GetAnswer(Guid answerID)
        {
            return _context.Answers.Single(x => x.AnswerID == answerID);
        }

        public AnswerSet GetAnswerSet(Guid answerSetID)
        {
            return _context.AnswerSets.Single(x => x.AnswerSetID == answerSetID);
        }

        public void UpdateAnswer(Answer answer)
        {
            _context.Answers.Update(answer);
            _context.SaveChanges();
        }

        public void UpdateAnswerSet(AnswerSet answerSet)
        {
            _context.AnswerSets.Update(answerSet);
            _context.SaveChanges();
        }
    }
}

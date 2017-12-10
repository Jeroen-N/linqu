using Magisco.Profile.Infrastructure;
using Magisco.Profile.Interfaces;
using Magisco.Profile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magisco.Profile.Services
{
    public class QuestionService : IQuestionService
    {
        public Context _context;

        public QuestionService(Context context)
        {
            _context = context;
        }

        public void CreateQuestion(Question question)
        {
            _context.Questions.Add(question);
            _context.SaveChanges();
        }

        public void CreateQuestionSet(QuestionSet questionSet)
        {

            _context.QuestionSets.Add(questionSet);
            _context.SaveChanges();
        }

        public void DeleteQuestion(Guid questionID)
        {
            _context.Questions.Remove(_context.Questions.Single(x => x.QuestionID == questionID));
            _context.SaveChanges();
        }

        public void DeleteQuestionSet(Guid questionSetID)
        {
            _context.QuestionSets.Remove(_context.QuestionSets.Single(x => x.QuestionSetID == questionSetID));
            _context.SaveChanges();
        }

        public IEnumerable<Question> GetAllQuestions()
        {
            return _context.Questions;
        }

        public IEnumerable<QuestionSet> GetAllQuestionSets()
        {
            return _context.QuestionSets;
        }

        public Question GetQuestion(Guid questionID)
        {
            return _context.Questions.Single(x => x.QuestionID == questionID);
        }

        public QuestionSet GetQuestionSet(Guid questionSetID)
        {
            return _context.QuestionSets.Single(x => x.QuestionSetID == questionSetID);
        }

        public void UpdateQuestion(Question question)
        {
            _context.Questions.Update(question);
            _context.SaveChanges();
        }

        public void UpdateQuestionSet(QuestionSet questionSet)
        {
            _context.QuestionSets.Update(questionSet);
            _context.SaveChanges();
        }
    }
}

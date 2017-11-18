using linqu.profileservice.Interfaces;
using linqu.profileservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace linqu.profileservice.Services
{
    public class QuestionService : IQuestionService
    {
        public bool CreateQuestion(Question question)
        {
            throw new NotImplementedException();
        }

        public bool CreateQuestionSet(QuestionSet questionSet)
        {
            throw new NotImplementedException();
        }

        public bool DeleteQuestion(Guid questionID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteQuestionSet(Guid questionSetID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Question> GetAllQuestions()
        {
            return null;
        }

        public IEnumerable<QuestionSet> GetAllQuestionSets()
        {
            throw new NotImplementedException();
        }

        public Question GetQuestion(Guid questionID)
        {
            throw new NotImplementedException();
        }

        public QuestionSet GetQuestionSet(Guid questionSetID)
        {
            throw new NotImplementedException();
        }

        public bool UpdateQuestion(Question question)
        {
            throw new NotImplementedException();
        }

        public bool UpdateQuestionSet(QuestionSet questionSet)
        {
            throw new NotImplementedException();
        }
    }
}

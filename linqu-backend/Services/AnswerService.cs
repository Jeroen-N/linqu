using linqu.profileservice.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using linqu.profileservice.Models;

namespace linqu.profileservice.Services
{
    public class AnswerService : IAnswerService
    {
        public bool CreateAnswer(Answer answer)
        {
            throw new NotImplementedException();
        }

        public bool CreateAnswerSet(AnswerSet answerSet)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAnswer(Guid answerID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAnswerSet(Guid answerSetID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Answer> GetAllAnswers()
        {
            var result = new List<Answer>();

            result.Add(new BoolAnswer() { AnswerID = new Guid(), AnswerType = Models.Enums.AnswerType.BoolAnswer });

            result.Add(new OpenAnswer() { AnswerID = new Guid(), AnswerType = Models.Enums.AnswerType.OpenAnswer });

            result.Add(new ListAnswer() { AnswerID = new Guid(), AnswerType = Models.Enums.AnswerType.ListAnswer });

            return result;
        }

        public IEnumerable<AnswerSet> GetAllAnswerSets()
        {
            throw new NotImplementedException();
        }

        public Answer GetAnswer(Guid answerID)
        {
            throw new NotImplementedException();
        }

        public AnswerSet GetAnswerSet(Guid answerSetID)
        {
            throw new NotImplementedException();
        }

        public bool UpdateAnswer(Answer answer)
        {
            throw new NotImplementedException();
        }

        public bool UpdateAnswerSet(AnswerSet answerSet)
        {
            throw new NotImplementedException();
        }
    }
}

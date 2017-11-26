using System.Collections.Generic;
using linqu.profileservice.Models;
using System;

namespace linqu.profileservice.Interfaces
{
    public interface IAnswerService
    {
        //getters
        IEnumerable<Answer> GetAllAnswers();
        IEnumerable<AnswerSet> GetAllAnswerSets();
        AnswerSet GetAnswerSet(Guid answerSetID);
        Answer GetAnswer(Guid answerID);

        //create
        void CreateAnswer(Answer answer);
        void CreateAnswerSet(AnswerSet answerSet);

        //modify
        void UpdateAnswer(Answer answer);
        void UpdateAnswerSet(AnswerSet answerSet);

        //delete
        void DeleteAnswer(Guid answerID);
        void DeleteAnswerSet(Guid answerSetID);
    }
}
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
        Boolean CreateAnswer(Answer answer);
        Boolean CreateAnswerSet(AnswerSet answerSet);

        //modify
        Boolean UpdateAnswer(Answer answer);
        Boolean UpdateAnswerSet(AnswerSet answerSet);

        //delete
        Boolean DeleteAnswer(Guid answerID);
        Boolean DeleteAnswerSet(Guid answerSetID);
    }
}
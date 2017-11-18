using linqu.profileservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace linqu.profileservice.Interfaces
{
    public interface IQuestionService
    {
        //getters
        IEnumerable<Question> GetAllQuestions();
        IEnumerable<QuestionSet> GetAllQuestionSets();
        QuestionSet GetQuestionSet(Guid questionSetID);
        Question GetQuestion(Guid questionID);

        //create
        Boolean CreateQuestion(Question question);
        Boolean CreateQuestionSet(QuestionSet questionSet);

        //modify
        Boolean UpdateQuestion(Question question);
        Boolean UpdateQuestionSet(QuestionSet questionSet);

        //delete
        Boolean DeleteQuestion(Guid questionID);
        Boolean DeleteQuestionSet(Guid questionSetID);

    }
}

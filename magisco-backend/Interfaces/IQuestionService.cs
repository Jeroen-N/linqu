using magisco.profileservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace magisco.profileservice.Interfaces
{
    public interface IQuestionService
    {
        //getters
        IEnumerable<Question> GetAllQuestions();
        IEnumerable<QuestionSet> GetAllQuestionSets();
        QuestionSet GetQuestionSet(Guid questionSetID);
        Question GetQuestion(Guid questionID);

        //create
        void CreateQuestion(Question question);
        void CreateQuestionSet(QuestionSet questionSet);

        //modify
        void UpdateQuestion(Question question);
        void UpdateQuestionSet(QuestionSet questionSet);

        //delete
        void DeleteQuestion(Guid questionID);
        void DeleteQuestionSet(Guid questionSetID);

    }
}

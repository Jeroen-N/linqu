using linqu.profileservice.Models;
using linqu.profileservice.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace linqu.profileservice.Infrastructure
{
    public static class Seed
    {
        private static ICollection<Question> questions = new List<Question>();
        private static ICollection<Answer> answers = new List<Answer>();
        
        public static async void SeedDatabase(Context context)
        {
            questions.Add(new BoolQuestion { QuestionID = new Guid(), DateCreated = DateTime.Now, LabelFalse = "Nee", LabelTrue="Ja", QuestionFor=QuestionFor.Developer, QuestionPhrased="Testvraag, werkt het?" });
            answers.Add(new BoolAnswer() { AnswerID = new Guid(), AnswerType = AnswerType.BoolAnswer, TimeAnswered = DateTime.Now, Value = true});

            if(!context.AnswerSets.Any() && !context.QuestionSets.Any())
            {
                context.QuestionSets.Add(
                    new QuestionSet { Category = "Culture", QuestionSetFor = QuestionFor.Developer, Questions = questions, QuestionSetID = new Guid()}
                    );
                context.AnswerSets.Add(
                    new AnswerSet { AnswerSetID = new Guid(), Answers = answers, TimeCompleted = DateTime.Now, Completed = true }
                    );
            }
        }
    }
}

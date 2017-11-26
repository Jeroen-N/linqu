using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using magisco.profileservice.Interfaces;
using magisco.profileservice.Models;

namespace magisco.profileservice.Controllers
{
    [Route("api/[controller]")]
    public class QuestionController : Controller
    {
        private IQuestionService _questionService;

        //inject services
        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        // get all questions
        [HttpGet]
        public IEnumerable<Question> GetAllQuestions()
        {
            return _questionService.GetAllQuestions();
        }

        //get a specific question
        [HttpGet("{id}", Name="GetQuestion")]
        public Question GetQuestion(string id)
        {
            return _questionService.GetQuestion(new Guid(id));
        }

        //create a question
        [HttpPut(Name = "CreateQuestion")]
        public void CreateQuestion(Question question)
        {
            _questionService.CreateQuestion(question);
        }

        //delete a question
        [HttpDelete("{id}", Name = "DeleteQuestion")]
        public void DeleteQuestion(string id)
        {
            _questionService.DeleteQuestion(new Guid(id));
        }

        //update a question
        [HttpPost(Name = "CreateQuestion")]
        public void UpdateQuestion(Question question)
        {
            _questionService.UpdateQuestion(question);
        }
    }
}

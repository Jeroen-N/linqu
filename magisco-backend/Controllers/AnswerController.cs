using magisco.profileservice.Interfaces;
using magisco.profileservice.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace magisco.profileservice.Controllers
{
    [Route("answers")]
    public class AnswerController : Controller
    {
        private IAnswerService _answerService;

        //inject services
        public AnswerController(IAnswerService answerService)
        {
            _answerService = answerService;
        }

        // get all answers
        [HttpGet]
        public IEnumerable<Answer> GetAllAnswers()
        {
            return _answerService.GetAllAnswers();
        }

        //get a specific answer
        [HttpGet("{id}", Name = "GetAnswer")]
        public Answer GetAnswer(string id)
        {
            return _answerService.GetAnswer(new Guid(id));
        }

        //create a answer
        [HttpPut(Name = "CreateAnswer")]
        public void CreateAnswer(Answer answer)
        {
            _answerService.CreateAnswer(answer);
        }

        //delete a answer
        [HttpDelete("{id}", Name = "DeleteAnswer")]
        public void DeleteAnswer(string id)
        {
            _answerService.DeleteAnswer(new Guid(id));
        }

        //update a answer
        [HttpPost(Name = "CreateAnswer")]
        public void UpdateAnswer(Answer answer)
        {
            _answerService.UpdateAnswer(answer);
        }
    }
}

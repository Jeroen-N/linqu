using linqu.profileservice.Interfaces;
using linqu.profileservice.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace linqu.profileservice.Controllers
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

        // GET api/values
        [HttpGet]
        public IEnumerable<Answer> GetAnswers()
        {
            return _answerService.GetAllAnswers();
        }        

        [HttpPost]
        public void SaveAnswer(Answer answer)
        {

        }

        [HttpPost]
        public void SaveAnswers(List<Answer> answers)
        {

        }

        [HttpPost]
        public void SaveAnswerSet(AnswerSet answerSet)
        {

        }
    }
}

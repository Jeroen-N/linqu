using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using magisco.profileservice.Interfaces;

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

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

    }
}

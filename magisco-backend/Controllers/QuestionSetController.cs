using magisco.profileservice.Interfaces;
using magisco.profileservice.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace magisco.profileservice.Controllers
{
    [Route("api/[controller]")]
    public class QuestionSetController
    {
        private IQuestionService _QuestionService;

        //inject services
        public QuestionSetController(IQuestionService QuestionService)
        {
            _QuestionService = QuestionService;
        }

        // get all QuestionSets
        [HttpGet]
        public IEnumerable<QuestionSet> GetAllQuestionSets()
        {
            return _QuestionService.GetAllQuestionSets();
        }

        //get a specific QuestionSet
        [HttpGet("{id}", Name = "GetQuestionSet")]
        public QuestionSet GetQuestionSet(string id)
        {
            return _QuestionService.GetQuestionSet(new Guid(id));
        }

        //create a QuestionSet
        [HttpPut(Name = "CreateQuestionSet")]
        public void CreateQuestionSet(QuestionSet QuestionSet)
        {
            _QuestionService.CreateQuestionSet(QuestionSet);
        }

        //delete a QuestionSet
        [HttpDelete("{id}", Name = "DeleteQuestionSet")]
        public void DeleteQuestionSet(string id)
        {
            _QuestionService.DeleteQuestionSet(new Guid(id));
        }

        //update a QuestionSet
        [HttpPost(Name = "CreateQuestionSet")]
        public void UpdateQuestionSet(QuestionSet QuestionSet)
        {
            _QuestionService.UpdateQuestionSet(QuestionSet);
        }
    }
}

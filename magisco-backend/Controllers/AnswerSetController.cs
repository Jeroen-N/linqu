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
    public class AnswerSetController
    {
        private IAnswerService _AnswerService;

        //inject services
        public AnswerSetController(IAnswerService AnswerService)
        {
            _AnswerService = AnswerService;
        }

        // get all AnswerSets
        [HttpGet]
        public IEnumerable<AnswerSet> GetAllAnswerSets()
        {
            return _AnswerService.GetAllAnswerSets();
        }

        //get a specific AnswerSet
        [HttpGet("{id}", Name = "GetAnswerSet")]
        public AnswerSet GetAnswerSet(string id)
        {
            return _AnswerService.GetAnswerSet(new Guid(id));
        }

        //create a AnswerSet
        [HttpPut(Name = "CreateAnswerSet")]
        public void CreateAnswerSet(AnswerSet AnswerSet)
        {
            _AnswerService.CreateAnswerSet(AnswerSet);
        }

        //delete a AnswerSet
        [HttpDelete("{id}", Name = "DeleteAnswerSet")]
        public void DeleteAnswerSet(string id)
        {
            _AnswerService.DeleteAnswerSet(new Guid(id));
        }

        //update a AnswerSet
        [HttpPost(Name = "CreateAnswerSet")]
        public void UpdateAnswerSet(AnswerSet AnswerSet)
        {
            _AnswerService.UpdateAnswerSet(AnswerSet);
        }
    }
}

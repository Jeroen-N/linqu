using Magisco.Profile.Interfaces;
using Magisco.Profile.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magisco.Profile.Controllers
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

        /// <summary>
        /// Get all answers available.
        /// </summary>
        /// <returns>List of answers.</returns>
        [HttpGet]
        public IEnumerable<Answer> GetAllAnswers()
        {
            return _answerService.GetAllAnswers();
        }

        /// <summary>
        /// Get a specific answer using ID.
        /// </summary>
        /// <param name="id">The ID to find the answer.</param>
        /// <returns>Answer found by ID.</returns>
        [HttpGet]
        [Route("{id}")]
        public Answer GetAnswer(string id)
        {
            return _answerService.GetAnswer(new Guid(id));
        }

        /// <summary>
        /// Create a new answer.
        /// </summary>
        /// <param name="answer">Answer object to create.</param>
        [HttpPut]
        public void CreateAnswer(Answer answer)
        {
            _answerService.CreateAnswer(answer);
        }

        /// <summary>
        /// Delete an answer.
        /// </summary>
        /// <param name="id">Answer ID to delete.</param>
        [HttpDelete]
        [Route("{id}")]
        public void DeleteAnswer(string id)
        {
            _answerService.DeleteAnswer(new Guid(id));
        }

        /// <summary>
        /// Update an answer.
        /// </summary>
        /// <param name="answer">Answer object to update.</param>
        [HttpPost]
        public void UpdateAnswer(Answer answer)
        {
            _answerService.UpdateAnswer(answer);
        }
    }
}

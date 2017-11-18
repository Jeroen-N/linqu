using System.Collections.Generic;
using linqu.profileservice.Models;

namespace linqu.profileservice.Interfaces
{
    public interface IAnswerService
    {
        IEnumerable<Answer> GetAllAnswers();
    }
}
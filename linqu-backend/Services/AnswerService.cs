﻿using linqu.profileservice.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using linqu.profileservice.Models;

namespace linqu.profileservice.Services
{
    public class AnswerService : IAnswerService
    {
        public IEnumerable<Answer> GetAllAnswers()
        {
            var result = new List<Answer>();

            result.Add(new BoolAnswer() { AnswerID = new Guid(), AnswerType = Models.Enums.AnswerType.BoolAnswer });

            result.Add(new OpenAnswer() { AnswerID = new Guid(), AnswerType = Models.Enums.AnswerType.OpenAnswer });

            result.Add(new ListAnswer() { AnswerID = new Guid(), AnswerType = Models.Enums.AnswerType.ListAnswer });



            return result;
        }
    }
}

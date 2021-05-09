using DynamicQuestionnaires.Application.DTO.Question;
using DynamicQuestionnaires.Infrastruture.Entities;
using DynamicQuestionnaires.Infrastruture.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicQuestionnaires.Application.Controllers
{
    [Route("api/questions")]
    public class QuestionController : ControllerBase
    {
        private IQuestionService _questionService;

        public QuestionController(
            IQuestionService questionService
          )
        {
            _questionService = questionService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateQuestion([FromBody] InAnswerDTO model)
        {
            Question question = new Question
            {
                 Description = model.Description
            };

            //foreach(string ans in model.Answers)
            //{
            //    Answer answer = new Answer
            //    {
            //        Description = ans
            //    };
            //    question.Answers.Add(answer);
            //}

            await _questionService.Create(question);

            return CreatedAtAction("GetById", new { idQuestionnaire = question.Id }, question);
        }

        [HttpGet("{idQuestion}")]
        public async Task<IActionResult> GetById(int idQuestion)
        {
            Question question = await _questionService.GetById(idQuestion);
            return Ok(question);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IEnumerable<Question> questions = await _questionService.GetAll();
            return Ok(questions);
        }
    }
}

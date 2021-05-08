using DynamicQuestionnaires.Application.DTO.Questionnaire;
using DynamicQuestionnaires.Infrastruture.Entities;
using DynamicQuestionnaires.Infrastruture.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicQuestionnaires.Application.Controllers
{   [Route("api/questionnaires")]
    public class QuestionnaireController : ControllerBase
    {

        private IQuestionnaireService _questionnaireService;

        
        public QuestionnaireController(IQuestionnaireService questionnaireService)
        {
            _questionnaireService = questionnaireService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateQuestionnaire([FromBody] InQuestionnaireDTO model)
        {

            Questionnaire questionnaire = new Questionnaire
            {
                Title = model.Title,
                StartQuestion = new Question()
                {
                    Description = model.question.Description
                }
        };


            foreach (string ans in model.question.Answers)
            {
                Answer answer = new Answer
                {
                    Description = ans
                };
                questionnaire.StartQuestion.Answers.Add(answer);
            }

            await _questionnaireService.Create(questionnaire);

            return CreatedAtAction("GetById", new { idQuestionnaire = questionnaire.Id }, questionnaire);
        }

        [HttpGet("{idQuestionnaire}")]
        public async Task<IActionResult> GetById(int idQuestionnaire)
        {
            Questionnaire questionnaire = await _questionnaireService.GetById(idQuestionnaire);
            return Ok(questionnaire);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IEnumerable<Questionnaire> questionnaires = await _questionnaireService.GetAll();
            return Ok(questionnaires);
        }

    }
}

using DynamicQuestionnaires.Infrastruture.Entities;
using DynamicQuestionnaires.Infrastruture.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicQuestionnaires.BLL.Services
{
    public class QuestionnaireService : IQuestionnaireService
    {
        private IUnitOfWork _unitOfWork;

        public QuestionnaireService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<bool> Create(Questionnaire questionnaire)
        {
            _unitOfWork.QuestionnaireRepository.Insert(questionnaire);
            return _unitOfWork.SaveAsync();
        }

        public Task<IEnumerable<Questionnaire>> GetAll()
        {
            return _unitOfWork.QuestionnaireRepository.Get();
        }

        public async Task<Questionnaire> GetById(int id)
        {
            IEnumerable<Questionnaire> questionnaire = await _unitOfWork.QuestionnaireRepository.Get(d => d.Id == id);
            if (questionnaire.Count() != 1)
            {
                return null;
            }

            return questionnaire.Single();
        }

        public Task<bool> Update(Questionnaire questionnaire)
        {
            _unitOfWork.QuestionnaireRepository.Update(questionnaire);
            return _unitOfWork.SaveAsync();
        }
    }
}

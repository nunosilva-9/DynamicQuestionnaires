using DynamicQuestionnaires.Infrastruture.Entities;
using DynamicQuestionnaires.Infrastruture.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicQuestionnaires.BLL.Services
{
    public class QuestionService : IQuestionService
    {
        private IUnitOfWork _unitOfWork;

        public QuestionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<bool> Create(Question question)
        {
            _unitOfWork.QuestionRepository.Insert(question);
            return _unitOfWork.SaveAsync();
        }

        public Task<IEnumerable<Question>> GetAll()
        {
            return _unitOfWork.QuestionRepository.Get();
        }

        public async Task<Question> GetById(int id)
        {
            IEnumerable<Question> question = await _unitOfWork.QuestionRepository.Get(d => d.Id == id,null,"Answers");
            if (question.Count() != 1)
            {
                return null;
            }

            return question.Single();
        }

        public Task<bool> Update(Question question)
        {
            _unitOfWork.QuestionRepository.Update(question);
            return _unitOfWork.SaveAsync();
        }
    }
}

using DynamicQuestionnaires.Infrastruture.Entities;
using DynamicQuestionnaires.Infrastruture.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicQuestionnaires.BLL.Services
{
    public class AnswerService : IAnswerService
    {
        private IUnitOfWork _unitOfWork;

        public AnswerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<bool> Create(Answer answer)
        {
            _unitOfWork.AnswerRepository.Insert(answer);
            return _unitOfWork.SaveAsync();
        }

        public Task<IEnumerable<Answer>> GetAll()
        {
            return _unitOfWork.AnswerRepository.Get();
        }

        public async Task<Answer> GetById(int id)
        {
            IEnumerable<Answer> answer = await _unitOfWork.AnswerRepository.Get(d => d.Id == id);
            if (answer.Count() != 1)
            {
                return null;
            }

            return answer.Single();
        }

        public Task<bool> Update(Answer answer)
        {
            _unitOfWork.AnswerRepository.Update(answer);
            return _unitOfWork.SaveAsync();
        }
    }
}

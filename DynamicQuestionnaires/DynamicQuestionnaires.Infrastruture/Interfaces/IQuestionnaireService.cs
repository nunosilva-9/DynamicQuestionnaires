using DynamicQuestionnaires.Infrastruture.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicQuestionnaires.Infrastruture.Interfaces
{
    public interface IQuestionService
    {
        Task<bool> Create(Question question);

        Task<bool> Update(Question question);

        Task<Question> GetById(int id);

        Task<IEnumerable<Question>> GetAll();

    }
}

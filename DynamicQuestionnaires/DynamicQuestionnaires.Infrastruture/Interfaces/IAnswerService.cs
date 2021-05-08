using DynamicQuestionnaires.Infrastruture.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicQuestionnaires.Infrastruture.Interfaces
{
    public interface IAnswerService
    {
        Task<bool> Create(Answer answer);

        Task<bool> Update(Answer answer);

        Task<Answer> GetById(int id);

        Task<IEnumerable<Answer>> GetAll();

    }
}

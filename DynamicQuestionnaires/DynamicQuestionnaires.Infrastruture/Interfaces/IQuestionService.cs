using DynamicQuestionnaires.Infrastruture.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicQuestionnaires.Infrastruture.Interfaces
{
    public interface IQuestionnaireService
    {
        Task<bool> Create(Questionnaire questionnaire);

        Task<bool> Update(Questionnaire questionnaire);

        Task<Questionnaire> GetById(int id);

        Task<IEnumerable<Questionnaire>> GetAll();

    }
}

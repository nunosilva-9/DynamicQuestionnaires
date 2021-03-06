using DynamicQuestionnaires.Infrastruture.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicQuestionnaires.Infrastruture.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> SaveAsync();

        IRepository<Questionnaire> QuestionnaireRepository { get; }

        IRepository<Question> QuestionRepository { get; }

        IRepository<Answer> AnswerRepository { get; }
    }
}

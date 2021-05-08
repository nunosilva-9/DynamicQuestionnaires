using DynamicQuestionnaires.DAL.DataContext;
using DynamicQuestionnaires.Infrastruture.Entities;
using DynamicQuestionnaires.Infrastruture.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicQuestionnaires.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork

    {
        private ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;

        }

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }


        private IRepository<Questionnaire> _questionnaireRepository;

        public IRepository<Questionnaire> QuestionnaireRepository
        {
            get
            {
                if (_questionnaireRepository == null)
                {
                    _questionnaireRepository = new Repository<Questionnaire>(_context);
                }
                return _questionnaireRepository;

            }
        }


        private IRepository<Question> _questionRepository;

        public IRepository<Question> QuestionRepository
        {
            get
            {
                if (_questionRepository == null)
                {
                    _questionRepository = new Repository<Question>(_context);
                }
                return _questionRepository;

            }
        }


        private IRepository<Answer> _answerRepository;

        public IRepository<Answer> AnswerRepository
        {
            get
            {
                if (_answerRepository == null)
                {
                    _answerRepository = new Repository<Answer>(_context);
                }
                return _answerRepository;

            }
        }
    }
}

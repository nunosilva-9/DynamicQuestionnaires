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

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}

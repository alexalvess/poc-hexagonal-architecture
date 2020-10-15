using Domain.Adapters;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataBase.InMemory.Repositories
{
    public class ClubRepository : IClubRepository
    {
        public Task<IEnumerable<Club>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> Insert(Club club)
        {
            throw new NotImplementedException();
        }
    }
}

using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Adapters
{
    public interface IClubRepository
    {
        Task<IEnumerable<Club>> GetAll();

        Task<int> Insert(Club club);
    }
}

using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IClubService
    {
        Task<IEnumerable<Club>> RecoverAllClubs();

        Task<int> RegisterAClub(Club club);
    }
}

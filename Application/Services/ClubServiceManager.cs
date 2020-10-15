using Domain.Adapters;
using Domain.Entities;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ClubServiceManager : IClubService
    {
        private readonly IEmailAdapter _emailAdapter;
        private readonly IClubRepository _clubRepository;

        public ClubServiceManager(IEmailAdapter emailAdapter, IClubRepository clubRepository) =>
            (_emailAdapter, _clubRepository) = (emailAdapter, clubRepository);

        public async Task<IEnumerable<Club>> RecoverAllClubs()
        {
            var clubs = await _clubRepository.GetAll();
            return clubs;
        }

        public async Task<int> RegisterAClub(Club club)
        {
            var id = await _clubRepository.Insert(club);

            _ = _emailAdapter.SendEmail("", "", "", "");

            return id;
        }
    }
}

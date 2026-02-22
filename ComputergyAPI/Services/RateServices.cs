using ComputergyAPI.Contexts;
using ComputergyAPI.DTOs.Rate;
using ComputergyAPI.Interfaces;

namespace ComputergyAPI.Services
{
    public class RateServices : IRate
    {
        private readonly ComputergyDbContext _computergyDbContext;
        public RateServices(ComputergyDbContext computergyDbContext)
        {
            _computergyDbContext = computergyDbContext;
        }

        Task<string> IRate.CreateRate(CreateRateDTO input)
        {
            throw new NotImplementedException();
        }
    }
}

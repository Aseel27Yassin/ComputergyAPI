using ComputergyAPI.DTOs.Rate;

namespace ComputergyAPI.Interfaces
{
    public interface IRate
    {
        Task<string> CreateRate(CreateRateDTO input);
    }
}

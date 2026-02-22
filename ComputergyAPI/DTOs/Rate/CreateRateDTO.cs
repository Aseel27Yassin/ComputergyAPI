namespace ComputergyAPI.DTOs.Rate
{
    public class CreateRateDTO
    {
        public int PersonId { get; set; }

        public string? Message { get; set; }

        public int RateAmount { get; set; }

        public int OrderId { get; set; }
    }
}

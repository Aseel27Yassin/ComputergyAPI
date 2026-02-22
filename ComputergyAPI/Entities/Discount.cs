namespace ComputergyAPI.Entities
{
    public class Discount : MainEntity
    {
        public string Code { get; set; }

        public string Percentage {  get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string? Description { get; set; }

        public string? ImageURL { get; set; }

        public int LimitUser {  get; set; }

        public float LimitAmount { get; set; }
    }
}

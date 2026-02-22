using ComputergyAPI.DTOs.Payment;

namespace ComputergyAPI.Interfaces
{
    public interface IPayment
    {
        public Task<bool> CreateUpdatePaymentCard(CreateUpdatePaymentCardDTO input);

        public Task<bool> removePaymentCard(int CartId);

        public Task<PaymentInputDTO> GetPaymentCard(int CartId);

        public Task<List<PaymentInputDTO>> GetAllPaymentCard(int UserId);
    }
}

using ComputergyAPI.DTOs.Payment;
using ComputergyAPI.Interfaces;

namespace ComputergyAPI.Services
{
    public class PaymentServices : IPayment
    {
        Task<bool> IPayment.CreateUpdatePaymentCard(CreateUpdatePaymentCardDTO input)
        {
            throw new NotImplementedException();
        }

        Task<List<PaymentInputDTO>> IPayment.GetAllPaymentCard(int UserId)
        {
            throw new NotImplementedException();
        }

        Task<PaymentInputDTO> IPayment.GetPaymentCard(int CartId)
        {
            throw new NotImplementedException();
        }

        Task<bool> IPayment.removePaymentCard(int CartId)
        {
            throw new NotImplementedException();
        }
    }
}

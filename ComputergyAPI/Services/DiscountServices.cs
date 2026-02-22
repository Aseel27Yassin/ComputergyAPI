using ComputergyAPI.DTOs.Discount;
using ComputergyAPI.Interfaces;

namespace ComputergyAPI.Services
{
    public class DiscountServices : IDiscount
    {
        Task<string> IDiscount.CreateDiscount(DiscountInputDTO input)
        {
            throw new NotImplementedException();
        }

        Task<bool> IDiscount.DeleteDiscount(int discountId)
        {
            throw new NotImplementedException();
        }

        Task<DiscountDTO> IDiscount.GetAllDiscount()
        {
            throw new NotImplementedException();
        }

        Task<string> IDiscount.UpdateDiscount(int discountId, DiscountInputDTO input)
        {
            throw new NotImplementedException();
        }
    }
}

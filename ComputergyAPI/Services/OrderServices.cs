using ComputergyAPI.DTOs.Order;
using ComputergyAPI.Interfaces;

namespace ComputergyAPI.Services
{
    public class OrderServices : IOrder
    {
        Task<string> IOrder.CreateUpdateOrder(CreateUpdateOrderInputDto input)
        {
            throw new NotImplementedException();
        }

        Task<string> IOrder.DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        Task<OrderDTO> IOrder.GetAllOrder()
        {
            throw new NotImplementedException();
        }

        Task<OrderDTO> IOrder.SearchOrder(SearchOrderInputDTO input)
        {
            throw new NotImplementedException();
        }
    }
}

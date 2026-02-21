using ComputergyAPI.DTOs.Order;

namespace ComputergyAPI.Interfaces
{
    public interface IOrder
    {
        Task<string> CreateUpdateOrder(CreateUpdateOrderInputDto input);

        Task<string> DeleteOrder(int id);

        Task<OrderDTO> GetAllOrder();

        Task<OrderDTO> SearchOrder(SearchOrderInputDTO input);

    }
}

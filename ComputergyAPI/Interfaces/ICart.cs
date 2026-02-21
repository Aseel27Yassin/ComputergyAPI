using ComputergyAPI.DTOs.Carts;

namespace ComputergyAPI.Interfaces
{
    public interface ICart
    {
        Task<string> ClearCart(int cartId);

        Task<string> CreateCart (int personId);

        Task<string> AddUpdateCart (CartItemDTO itemDTO);
        
        Task<string> RemoveFromCart (int CartItemId);

        Task<string> DeleteWishList();

        Task<string> CreateWishList();

        Task<string> AddToWishList(int itemId);

        Task<string> RemoveFromWishList(int itemId);

    }
}

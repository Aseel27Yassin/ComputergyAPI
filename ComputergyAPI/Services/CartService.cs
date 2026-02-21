using ComputergyAPI.DTOs.Carts;
using ComputergyAPI.Interfaces;

namespace ComputergyAPI.Services
{
    public class CartService : ICart
    {
        Task<string> ICart.AddToWishList(int itemId)
        {
            throw new NotImplementedException();
        }

        Task<string> ICart.AddUpdateCart(CartItemDTO itemDTO)
        {
            throw new NotImplementedException();
        }

        Task<string> ICart.ClearCart(int cartId)
        {
            throw new NotImplementedException();
        }

        Task<string> ICart.CreateCart(int personId)
        {
            throw new NotImplementedException();
        }

        Task<string> ICart.CreateWishList()
        {
            throw new NotImplementedException();
        }

        Task<string> ICart.DeleteWishList()
        {
            throw new NotImplementedException();
        }

        Task<string> ICart.RemoveFromCart(int CartItemId)
        {
            throw new NotImplementedException();
        }

        Task<string> ICart.RemoveFromWishList(int itemId)
        {
            throw new NotImplementedException();
        }
    }
}

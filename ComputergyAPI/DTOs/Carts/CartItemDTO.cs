namespace ComputergyAPI.DTOs.Carts

{
    public class CartItemDTO
    {
        public int CartID { get; set; }

        public int ItemID { get; set; }

        public int Quantity { get; set; }

        public float TotalPrice { get; set; }

        public string Note { get; set; }

        public int? CartItemID { get; set; }
    }
}

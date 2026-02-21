using System.Security.Cryptography.X509Certificates;

namespace ComputergyAPI.Entities
{
    public class CartItem
    {
        public int CartID { get; set; }

        public int ItemID {  get; set; }

        public int Quantity { get; set; }

        public float TotalPrice { get; set; }

        public string Note { get; set; }
    }
}

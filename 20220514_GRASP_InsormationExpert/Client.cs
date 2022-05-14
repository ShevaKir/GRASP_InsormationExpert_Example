using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220514_GRASP_InsormationExpert
{
    class Client
    {
        #region correct use

        public int GetCorrectOrderPrice(Order order)
        {
            return order.GetAllPrice();
        }

        #endregion

        #region problem examples

        public int GetOrderPrice(Order order)
        {
            List<OrderItem> orderItems = order.OrderItems;

            int result = 0;

            foreach (OrderItem item in orderItems)
            {
                int amount = item.Amount;

                Product product = item.Product;

                int price = product.Price;

                result += price * amount;
            }

            return result;
        }

        #endregion
    }
}

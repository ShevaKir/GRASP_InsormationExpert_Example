using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220514_GRASP_InsormationExpert
{
    class Order
    {
        private List<OrderItem> _items;
        private string _address;


        #region correct use

        public int GetAllPrice()
        {
            int result = 0;

            foreach (OrderItem item in _items)
            {
                result += item.GetPrice();
            }

            return result;
        }

        #endregion

        #region problem examples

        public List<OrderItem> OrderItems 
        {
            get
            {
                return _items;
            }
        }

        #endregion


    }
}

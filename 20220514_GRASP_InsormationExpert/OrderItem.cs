using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220514_GRASP_InsormationExpert
{
    class OrderItem
    {
        private Product _product;
        private int _amount;

        #region correct use

        public int GetPrice()
        {
            return _amount * _product.Price;
        }

        #endregion


        #region problem examples

        public int Amount 
        {
            get
            {
                return _amount;
            }
        }

        public Product Product
        {
            get 
            { 
                return _product; 
            }
        }

        #endregion
    }
}

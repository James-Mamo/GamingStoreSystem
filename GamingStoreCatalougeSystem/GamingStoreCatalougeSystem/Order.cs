using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingStoreCatalougeSystem
{
    class Order
    {

       protected string orderName;
       protected string orderDescription;


        public string OrderName
        {
            get
            {
                return orderName;
            }
        }

        public string OrderDescription
        {
            get
            {
                return orderDescription;
            }
        }

        public Order(string pOrderName, string pOrderDescription)
        {
            orderDescription = pOrderDescription;
            orderName = pOrderName;
        }



    }
}

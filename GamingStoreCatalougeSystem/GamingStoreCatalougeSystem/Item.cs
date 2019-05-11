using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingStoreCatalougeSystem
{
    public class Item
    {
        protected string name;
        protected string genre;
        protected string price;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Genre
        {
            get
            {
                return genre;
            }
        }

        public string Price
        {
            get
            {
                return price;
            }
        }

        public Item()
        {
            name = "";
            genre = "";
            price = "";
        }

        public Item (string pName, string pGenre, string pPrice)
        {
            name = pName;
            genre = pGenre;
            price = pPrice;
        }
    }
}

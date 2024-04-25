using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Cart
    {
        //Список товаров
        private List<Item> _items;

        /// <summary>
        /// Список товаров
        /// </summary>
        public List<Item> Items
        {  
            get { return _items; } 
            set { _items = value; }
        }

        /// <summary>
        /// Возвращает стоимость
        /// </summary>
        public double Amount 
        {  
            get
            {
                double amount = 0;
                if (_items != null)
                {
                    
                    foreach (Item item in _items)
                    {
                        amount += item.Cost;
                    }
                }
                return amount;
            }
            
        }

        public Cart()
        {
            Items = new List<Item>();
        }
    }
}

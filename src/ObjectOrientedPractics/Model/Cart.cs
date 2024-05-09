using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Cart : ICloneable
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

        private Cart(List<Item> items) 
        { 
            Items = new List<Item>();
            if (items != null) 
            { 
                foreach(var item in items)
                {
                    Items.Add(item);
                }
            }
		}

        

		// Реализация ICloneable вместо конструктора копирования
		public object Clone()
		{
			return new Cart(this.Items);
		}
	}
}

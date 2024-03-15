using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Store
    {
        /// <summary>
        /// Список товаров
        /// </summary>
        private List<Item> _items;
        /// <summary>
        /// Список пользователей
        /// </summary>
        private List <Customer> _customer;

        /// <summary>
        /// Св-во поля _items
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Св-во поля _customer
        /// </summary>
        public List<Customer> Customer
        { 
            get { return _customer; } 
            set {  _customer = value; } 
        }
        
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Store()
        {
            _items = new List <Item> ();
            _customer = new List <Customer> ();
        }
    }
}

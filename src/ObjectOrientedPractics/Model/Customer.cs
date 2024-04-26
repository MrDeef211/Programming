

using ObjectOrientedPractics.Servises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Model.Discounts;


namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Покупатель
    /// </summary>
    public class Customer
    {
        //генератор айди
        private static int _count = 0;
        //айди
        private readonly int _id = _count++;
        //имя фамилия
        private string _fullname;
        //Адресс
        private Address _address;
        //Корзина
        private Cart _cart;
        //Заказы
        private List<Order> _orders;
        //Приоритетный клиент
        public bool _isPriority;
        //Список скидок
        private List<IDiscount> _discounts;


        
        /// <summary>
        /// имя фамилия
        /// </summary>
        public string FullName
        {
            set { _fullname = ValueValidator.AssertStringOnLength(value, 200, "fullname"); }
            get { return _fullname; }
        }

        /// <summary>
        /// Адресс
        /// </summary>
        public Address Address
        {
            set { _address = value; }
            get { return _address; }
        }

        /// <summary>
        /// айди
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Корзина
        /// </summary>
        public Cart Cart
        {
            set { _cart = value; }
            get { return _cart; }
        }

        /// <summary>
        /// Заказы
        /// </summary>
        public List<Order> Orders
        {
            set { _orders = value; }
            get { return _orders; }
        }

        /// <summary>
        /// Список скидок
        /// </summary>
        public List<IDiscount> Discounts
        {
            set { _discounts = value; }
            get { return _discounts; }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="fullname">имяФамилия</param>
        /// <param name="address">адресс</param>
        public Customer(string fullname, Address address, bool isPriority) 
        { 
            if (fullname != "")
                FullName = fullname;
            else 
                FullName = Id.ToString();
            Address = new Address(address.Index, address.Country, address.City, address.Street, address.Building, address.Apartment);
            Cart = new Cart();
            Orders = new List<Order>();
            _isPriority = isPriority;
            Discounts = new List<IDiscount>
            {
                new PointsDiscount()
            };
        }
        //Отображение
        public override string ToString()
        {
            return FullName; // Возвращаем значение свойства Fullname
        }
    }
}

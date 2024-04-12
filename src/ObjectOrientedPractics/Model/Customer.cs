

using ObjectOrientedPractics.Servises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


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


        
        //имя фамилия
        public string FullName
        {
            set { _fullname = ValueValidator.AssertStringOnLength(value, 200, "fullname"); }
            get { return _fullname; }
        }
        //Адресс
        public Address Address
        {
            set { _address = value; }
            get { return _address; }
        }
        // айди
        public int Id
        {
            get { return _id; }
        }
        //Корзина
        public Cart Cart
        {
            set { _cart = value; }
            get { return _cart; }
        }
        //Заказы
        public List<Order> Orders
        {
            set { _orders = value; }
            get { return _orders; }
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="fullname">имяФамилия</param>
        /// <param name="address">адресс</param>
        public Customer(string fullname, Address address) 
        { 
            if (fullname != "")
                FullName = fullname;
            else 
                FullName = Id.ToString();
            Address = new Address(address.Index, address.Country, address.City, address.Street, address.Building, address.Apartment);
            Cart = new Cart();
        }
        //Отображение
        public override string ToString()
        {
            return FullName; // Возвращаем значение свойства Fullname
        }
    }
}

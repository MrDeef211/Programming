using ObjectOrientedPractics.Servises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Order
    {
        // генератор айди
        private static int _count = 0;
        // айди
        private readonly int _id;
        // дата создания заказа
        private readonly DateTime _date;
        // адресс доставки
        private Address _address;
        // список товаров
        private List<Item> _items;
        // общая стоимость
        private double _cost;
        //Статус заказа
        private OrderStatus _status;
        //Заказчик
        private Customer _customer;

        // айди
        public int Id
        {
            get { return _id; }
        }

        public DateTime Date
        {
            get { return _date; }
        }

        // адресс
        public Address Address
        {
            set { _address = value; }
            get { return _address; }
        }

        // список товаров
        public List<Item> Items
        {
            set { _items = value; }
            get { return _items; }
        }

        // общая стоимость
        public double Cost
        { 
            set { _cost = value; }
            get { return _cost; }
        }

        //Статус заказа
        public OrderStatus Status
        { 
            get { return _status; }
            set { _status = value; }
        }

        //Заказчик
        public Customer Customer
        {
            set { _customer = value; }
            get { return _customer; }
        }

        /// <summary>
        /// Заказ покупателя
        /// </summary>
        /// <param name="name">имя заказа</param>
        /// <param name="address">адресс доставки</param>
        /// <param name="items">список товаров</param>
        /// <param name="cost">общая стоимость</param>
        /// <param name="status">статус заказа</param>
        public Order(Address address, List<Item> items, double cost, OrderStatus status)
        {
            _id = _count++;
            _date = DateTime.UtcNow;
            Address = new Address(address.Index, address.Country, address.City, address.Street, address.Building, address.Apartment);
            Items = new List<Item>(items);
            Cost = cost;
            Status = status;
        }

        /// <summary>
        /// Заказ на покупателя
        /// </summary>
        /// <param name="address">адресс доставки</param>
        /// <param name="cost">общая стоимость</param>
        /// <param name="status">статус заказа</param>
        /// <param name="customer">заказчик</param>
        public Order(int Id,DateTime date, Address address, double cost, OrderStatus status, Customer customer, List<Item> items)
        {
            _id = Id;
            _date = date;
            Address = new Address(address.Index, address.Country, address.City, address.Street, address.Building, address.Apartment);
            Cost = cost;
            Status = status;
            Customer = customer;
            Items = new List<Item>(items);
        }

        public Order()
        {
            _id = _count++;
            _date = DateTime.UtcNow;
            Items = new List<Item>();
        }


    }

    // Статус заказа
    public enum OrderStatus
    {
        New, // Новый 
        Processing, // Обрабатывается
        Assembly, // Собирается на складе
        Sent, // Отправлен
        Delivered, // Доставлен
        Returned, // Возврат
        Abadoned // Отменен (со стороны магазина)
    }
}

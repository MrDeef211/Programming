using ObjectOrientedPractics.Servises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Order
    {
        // генератор айди
        private static int _count = 0;
        // айди
        private readonly int _id = _count++;
        // дата создания заказа
        private readonly DateTime _date = DateTime.UtcNow;
        // адресс доставки
        private Address _address;
        // список товаров
        private List<Item> _items;
        // общая стоимость
        private double _cost;
        //Статус заказа
        private OrderStatus _status;

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">имя заказа</param>
        /// <param name="address">адресс доставки</param>
        /// <param name="items">список товаров</param>
        /// <param name="cost">общая стоимость</param>
        public Order(Address address, List<Item> items, double cost, OrderStatus status)
        {
            Address = new Address(address.Index, address.Country, address.City, address.Street, address.Building, address.Apartment);
            Items = new List<Item>(items);
            Cost = cost;
            Status = status;
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

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
        // имя заказа
        private string _name;
        // адресс доставки
        private Address _address;
        // список товаров
        private List<Item> _items;
        // общая стоимость
        private int _cost;

        // имя заказа
        public string Name
        {
            set { _name = ValueValidator.AssertStringOnLength(value, 200, "name"); }
            get { return _name; }
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
        public int Cost
        { 
            set { _cost = value; }
            get { return _cost; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">имя заказа</param>
        /// <param name="address">адресс доставки</param>
        /// <param name="items">список товаров</param>
        /// <param name="cost">общая стоимость</param>
        public Order(string name, Address address, List<Item> items, int cost)
        {
            Name = name;
            Address = address;
            Items = items;
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

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.Model
{
    internal class PriorityOrder : Order 
    {
        //Дата доставки
        private DateTime _deliveryDate;
        //Время доставки
        private string _deliveryTime;
        //Возможные переоды доставки
        private string[] _deliveryTimes = {
            "9:00 – 11:00",
            "11:00 – 13:00",
            "3:00 – 15:00",
            "15:00 – 17:00",
            "17:00 – 19:00",
            "19:00 – 21:00"
        };

        //Дата доставки
        public DateTime DeliveryDate
        {
            set { _deliveryDate = value; }
            get { return _deliveryDate; }
        }

        //Время доставки
        public string DeliveryTime
        {
            set 
            { 
                foreach (string time in _deliveryTimes)
                {
                    if (value == time) 
                    { 
                        _deliveryTime = time;
                        return;
                    }
                    throw new ArgumentException("Неправильное время");
                }
            }
            get { return _deliveryTime; }
        }

        /// <summary>
        /// Приоритетный заказ
        /// </summary>
        /// <param name="address">Адресс доставки</param>
        /// <param name="items">Список заказов</param>
        /// <param name="cost">Стоимость заказа</param>
        /// <param name="status">Статус заказа</param>
        /// <param name="deliveryDate">Дата доставки</param>
        /// <param name="deliveryTime">Время доставки</param>
        public PriorityOrder(Address address, List<Item> items, double cost, OrderStatus status, DateTime deliveryDate, string deliveryTime) : base(address, items, cost, status)
        {
            DeliveryDate = deliveryDate;
            DeliveryTime = deliveryTime;
        }
    }

}

﻿

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
    internal class Customer
    {
        //генератор айди
        private static int _count = 0;
        //айди
        private readonly int _id = _count++;
        //имя фамилия
        private string _fullname;
        //Адресс
        private Address _address;


        
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
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="id">айди</param>
        /// <param name="fullname">имяфамилия</param>
        /// <param name="address">адресс</param>
        public Customer(string fullname, Address address) 
        { 
            FullName = fullname;   
            Address = address;
        }
        //Отображение
        public override string ToString()
        {
            return FullName; // Возвращаем значение свойства Fullname
        }
    }
}

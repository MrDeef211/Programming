using ObjectOrientedPractics.Servises;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.Model
{
    public class Address : ICloneable
    {
        //почтовый индекс, целое шестизначное число.
        private int _index;
        //страна/регион, строка, не более 50 символов.
        private string _country;
        //город (населенный пункт), строка, не более 50 символов.
        private string _city;
        //улица, строка, не более 100 символов.
        private string _street;
        //номер дома, строка, не более 10 символов.
        private string _building;
        //номер квартиры/помещения, не более 10 символов
        private string _apartment;

        //почтовый индекс, целое шестизначное число.
        public int Index
        {
            set
            {
                if (value > 99999 & value <= 999999)
                {
                    _index = value;
                }
                else
                {
                    throw new Exception("Index must have 6 symbols");
                }
            }

            get { return _index; }
        }

        //страна/регион, строка, не более 50 символов.
        public string Country
        {
            set { _country = ValueValidator.AssertStringOnLength(value, 50, "country"); }
            get { return _country; }
        }

        //город (населенный пункт), строка, не более 50 символов.
        public string City
        {
            set { _city = ValueValidator.AssertStringOnLength(value, 50, "city"); }
            get { return _city; }
        }

        //улица, строка, не более 100 символов.
        public string Street
        {
            set { _street = ValueValidator.AssertStringOnLength(value, 100, "street"); }
            get { return _street; }
        }

        //номер дома, строка, не более 10 символов.
        public string Building
        {
            set { _building = ValueValidator.AssertStringOnLength(value, 10, "building"); }
            get { return _building; }
        }

        //номер квартиры/помещения, не более 10 символов
        public string Apartment
        {
            set { _apartment = ValueValidator.AssertStringOnLength(value, 10, "apartment"); }
            get { return _apartment; }
        }

        public Address ()
        {
            Index = 111111;
            Country = "";
            City = "";
            Street = "";
            Building = "";
            Apartment = "";
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="index">Почтовый индекс</param>
        /// <param name="country">Страна проживания</param>
        /// <param name="city">Город проживания</param>
        /// <param name="street">Улица</param>
        /// <param name="building">Номер дома</param>
        /// <param name="apartment">Номер квартиры</param>
        public Address (int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

		// Реализация ICloneable вместо конструктора копирования
		public object Clone()
		{
			return new Address(this.Index, this.Country, this.City, this.Street, this.Building, this.Apartment);
		}

		// Реализация IEquatable<>
		public override bool Equals(object other)
		{
			// Обязательные проверки прежде чем мы сравним поля
			if (other == null)
				return false;

			if (!(other is Address))
				return false;

			if (object.ReferenceEquals(this, other))
				return true;

			var person2 = (Address)other;

			// Только теперь мы можем сделать собственное сравнение
			return (this.Index == person2.Index && this.Country == person2.Country && 
                    this.City == person2.City && this.Street == person2.Street && 
                    this.Building == person2.Building && this.Apartment == person2.Apartment);
		}

		//Отображение
		public override string ToString()
        {
            return (City + " " + Street + " " + Building + " " + Apartment); // Возвращаем значение свойства Fullname
        }
    }
}

using ObjectOrientedPractics.Servises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Товар
    /// </summary>
    internal class Item
    {
        //генератор айди
        private static int _count = 0;
        //айди
        private readonly int _id = _count++;
        //имя товара
        private string _name;
        //описание
        private string _info;
        //стоимость
        private double _cost;


        //имя товара
        public string Name
        {
            set { _name = ValueValidator.AssertStringOnLength(value, 200, "name"); }
            get { return _name; }
        }
        //описание
        public string Info
        {
            set { _info = ValueValidator.AssertStringOnLength(value, 1000, "info"); }
            get { return _info; }
        }
        //стоимость
        public double Cost
        {
            set
            {
                if (value > 0 && value <= 100000)
                {
                    _cost = value;
                }
                else
                {
                    throw new ArgumentException("Out of lenght");
                }
            }
            get { return _cost; }
        }
        //айди
        public int Id
        {
            get { return _id; }
        }
        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="name">айди</param>
        /// <param name="info">описание</param>
        /// <param name="cost">стоимость</param>
        public Item(string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
        }

        //Отображение
        public override string ToString()
        {
            return Name; // Возвращаем значение свойства Name
        }
    }


}

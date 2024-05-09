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
    [Serializable]
    public class Item : ICloneable
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
        //категория товара
        private Category _category;


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
                if (value >= 0 && value <= 100000)
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
        /// Котегория товара
        /// </summary>
        public Category Category
        {
            set => _category = value;
            get { return _category; }
        }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="name">айди</param>
        /// <param name="info">описание</param>
        /// <param name="cost">стоимость</param>
        /// <param name="category">категория товара</param>
        public Item(string name, string info, double cost, Category category)
        {
            if (name != "")
                Name = name;
            else
                Name = Id.ToString();
            Info = info;
            Cost = cost;
            Category = category;
        }

		// Реализация ICloneable вместо конструктора копирования
		public object Clone()
		{
			return new Item(this.Name, this.Info, this.Cost, this.Category);
		}

		// Реализация IEquatable<>
		public override bool Equals(object other)
		{
			// Обязательные проверки прежде чем мы сравним поля
			if (other == null)
				return false;

			if (!(other is Item))
				return false;

			if (object.ReferenceEquals(this, other))
				return true;

			var person2 = (Item)other;

			// Только теперь мы можем сделать собственное сравнение
			return (this.Name == person2.Name);
		}

		// Реализация IComparable <>
		public int CompareTo(object other)
		{
			if (other == null) return 1;

			Item otherItem = (Item)other;

			if (otherItem != null)
				return this.Cost.CompareTo(otherItem.Cost);
			else
				throw new ArgumentException("Object is not a Item");
		}

		//Отображение
		public override string ToString()
        {
            return Name; // Возвращаем значение свойства Name
        }
    }

    /// <summary>
    /// Категории товара
    /// </summary>
    public enum Category
    {
        None,
        Toy,
        Food,
        Electronic,
        Cloth,
        Shoes,
        Sport,
        Medicine,
        Furniture,
        Accessory,
        Game
    }
}

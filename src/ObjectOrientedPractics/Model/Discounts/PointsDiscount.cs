using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    public class PointsDiscount : IDiscount
    {
        //Количество накопленных балов
        private int _points;

        /// <summary>
        /// Количество накопленных балов
        /// </summary>
        public int Points
        {
            private set { _points = value; }
            get { return _points; }
        }

        /// <summary>
        /// Возвращает информацию о баллах
        /// </summary>
        public string Info
        {
            get 
            {
                string info = "Накопительная – " + Points + " баллов";
                return (info);
            }
        }

        /// <summary>
        /// Принимает на вход список продуктов и возвращает размер скидки, 
        /// доступной для этого списка продуктов с текущим количеством баллов.
        /// </summary>
        /// <param name="items">Список продуктов</param>
        /// <returns>Размер скидки</returns>
        public double Calculate(List<Item> items)
        {
            //Стоимость товаров
            double cost = 0;
            foreach (var item in items)
            {
                cost += item.Cost;
            }

            //Расчёт максимальной скидки
            double maxDiscont = Math.Truncate(cost * 0.3);

            if ((int)maxDiscont < Points) { return maxDiscont; }
            else { return Points; }
        }

        /// <summary>
        /// Применяет скидку к товарам 
        /// </summary>
        /// <param name="items">Список продуктов</param>
        /// <returns>Размер скидки</returns>
        public double Apply(List<Item> items)
        {
            //Расчёт скидки
            double discount = Calculate(items);
            //Снятие баллов
            Points -= (int)discount;

            return discount;
        }

        /// <summary>
        /// Добавляет баллы на основе полученного списка товаров.
        /// </summary>
        /// <param name="items">Список продуктов</param>
        public void Update(List<Item> items)
        {
            //Стоимость товаров
            double cost = 0;
            foreach (var item in items)
            {
                cost += item.Cost;
            }

            //Количество добавляемых баллов
            double newPoints = cost * 0.1;
            //Округление
            if ((newPoints % 1) > 0)
            {
                newPoints = Math.Truncate(newPoints) + 1;
            }

            Points += (int)newPoints;
        }

        public PointsDiscount()
        {
            Points = 0;
        }

		// Реализация IComparable <>
		public int CompareTo(object other)
		{
			if (other == null) return 1;

			PointsDiscount otherDiscount = (PointsDiscount)other;

			if (otherDiscount != null)
				return this.Points.CompareTo(otherDiscount.Points);
			else
				throw new ArgumentException("Object is not a Discount");
		}

		//Отображение
		public override string ToString()
        {
            return Info; // Возвращаем значение свойства Info
        }

    }
}

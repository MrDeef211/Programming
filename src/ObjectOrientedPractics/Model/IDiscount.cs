using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public interface IDiscount
    {
        /// <summary>
        /// Информация о скидке
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Принимает на вход список продуктов и возвращает размер скидки
        /// </summary>
        /// <param name="items">Список продуктов</param>
        /// <returns>Размер скидки</returns>
        double Calculate(List<Item> items);

        /// <summary>
        /// Применяет скидку к товарам 
        /// </summary>
        /// <param name="items">Список продуктов</param>
        /// <returns>Размер скидки</returns>
        double Apply(List<Item> items);

        /// <summary>
        /// Обновляет скидку на основе полученного списка товаров.
        /// </summary>
        /// <param name="items">Список продуктов</param>
        void Update(List<Item> items);

        /// <summary>
        /// Сравнивает с другим объектом
        /// </summary>
        /// <param name="other">Объект скидки</param>
        /// <returns>Знак сравнения</returns>
        int CompareTo(object other);



	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Servises
{
	public static class DataTools
	{
		/// <summary>
		/// Фильтрация списка
		/// </summary>
		/// <param name="items">Список предметов</param>
		/// <param name="filter">Критерий фильтрации</param>
		/// <returns>Отфильтрованный список</returns>
		public static List<Item> Filter(List<Item> items, Predicate<Item> filter) 
		{ 
			List<Item> OutputItems = new List<Item>();

			//Фильтрация
			for (int i = 0; i < items.Count; i++)
			{
				if (filter(items[i]))
					OutputItems.Add(items[i]);
			}

			return OutputItems;
		}

		/// <summary>
		/// Сортировка списка
		/// </summary>
		/// <param name="items">Список предметов</param>
		/// <param name="filter">Критерий сортировки</param>
		/// <returns>Отсортированный список</returns>
		public static List<Item> Sort(List<Item> items, Func<Item, Item, bool> filter) 
		{
			List<Item> OutputItems = new List<Item>();

			//Копирование
			for (int i = 0; i < items.Count; i++)
			{
				OutputItems.Add(items[i]);
			}

			Item buffer;

			//Тело сортировки
			for (int i = 0; i < OutputItems.Count; i++)
				for (int j = 0; j < OutputItems.Count - 1 - i; j++)
				{
					//swap
					if (filter(OutputItems[j], OutputItems[j+1]))
					{
						buffer = OutputItems[j];
						OutputItems[j] = OutputItems[j+1];
						OutputItems[j+1] = buffer;
						buffer = null;
					}
				}


			return OutputItems;

		}



	}
}

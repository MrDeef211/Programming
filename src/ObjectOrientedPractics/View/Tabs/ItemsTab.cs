using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Servises;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        //Изменение предметов
        public static event EventHandler<EventArgs> ItemsChanged;



        private static List<Item> _items = new List<Item>();

        private List<Item> _displayedItems;


		public static List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

		public ItemsTab()
        {
            InitializeComponent();
            // Инициализация Комбобокса категорий
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            _displayedItems = Items;
        }


		///////////////////////////////////////////////////////////// Сервисные методы
		public void UppdateListBox(List<Item> newItems)
		{
			ItemsListBox.Items.Clear();
			ItemsListBox.SelectedIndex = -1;
			ClearInputs();
			if (newItems != null)
			{
				for (int i = 0; i < newItems.Count; i++)
				{
					ItemsListBox.Items.Add(newItems[i].Name);
				}
			}
		}

		//Обновление экрана
		private void ClearInputs()
		{
			IDTextBox.Text = "";
			NameTextBox.Text = "";
			DescriptionTextBox.Text = "";
			CostTextBox.Text = "";
		}


		///////////////////////////////////////////////////////////// Работа с ItemListBox

		//Нажатие на кнопку добавление
		//Добавляет обьект в список
		private void AddButton_Click(object sender, EventArgs e)
        {
            //Проверка пройденной валидации
            if (NameTextBox.BackColor != Color.Red && DescriptionTextBox.BackColor != Color.Red && CostTextBox.BackColor != Color.Red)
            {
                //Стоимость в число
                double bufferCost;
                if (!double.TryParse(CostTextBox.Text, out bufferCost))
                    bufferCost = 0;

                //Что выделенно
                if (ItemsListBox.SelectedIndex != -1)
                {
                    //Выбранный обьект                     
                    int index = ItemsListBox.SelectedIndex;
					Item selectedItem = _displayedItems[index];
					//Изменение выбранного обьекта
					selectedItem.Cost = bufferCost;
                    selectedItem.Name = NameTextBox.Text;
                    selectedItem.Info = DescriptionTextBox.Text;
                    selectedItem.Category = (Category)CategoryComboBox.SelectedItem;


                }
                else
                {
                    //Создание нового обьекта
                    Item newItem = new Item(NameTextBox.Text, DescriptionTextBox.Text, bufferCost, (Category)CategoryComboBox.SelectedItem);
                    Items.Add(newItem);
                }

				//Фильтр + Сортировка + Обновление
				FindTextBox_TextChanged(sender, e);

                //Обновление
                ItemsChanged?.Invoke(this, EventArgs.Empty);
			}
        }

		//Нажатие кнопки удаления
		//Удаляет выделенный обьект
		private void RemoveButton_Click(object sender, EventArgs e)
		{
			int index = ItemsListBox.SelectedIndex;
            Item SelectedItem = _displayedItems[index];
			if (index != -1)
			{
				Items.Remove(SelectedItem);

				//Фильтр + Сортировка + Обновление
				FindTextBox_TextChanged(sender, e);

                //Обновление
                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }


        }

		//Выбор обьекта
		private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ItemsListBox.SelectedIndex != -1)
			{
				Item selectedItem = _displayedItems[ItemsListBox.SelectedIndex];
				//Заполнение полей
				IDTextBox.Text = selectedItem.Id.ToString();
				NameTextBox.Text = selectedItem.Name;
				DescriptionTextBox.Text = selectedItem.Info;
				CostTextBox.Text = selectedItem.Cost.ToString();
				CategoryComboBox.SelectedIndex = (int)selectedItem.Category;
			}
		}

		///////////////////////////////////////////////////////////// Редактирование полей

		//Редактирование поля имени + валидация
		private void NameTextBox_Change(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Length  <= 200)
            {
                NameTextBox.BackColor = Color.White;
            }
            else
            {
                NameTextBox.BackColor = Color.Red;
            }
        
        }

        //Редактирование поля описание + валидация
        private void DescriptionTextBox_Change(object sender, EventArgs e)
        {
            if (DescriptionTextBox.Text.Length <= 1000)
            {
                DescriptionTextBox.BackColor = Color.White;
            }
            else
            {
                DescriptionTextBox.BackColor = Color.Red;
            }

        }

        //Редактированик поля стоимости + валидация
        private void CostTexBox_Change(object sender, EventArgs e)
        {
            float bufferCost;
            if (float.TryParse(CostTextBox.Text, out bufferCost))
            {
                if (bufferCost >= 0 && bufferCost <= 100000)
                {
                    CostTextBox.BackColor = Color.White;
                }
                else
                {
                CostTextBox.BackColor = Color.Red;
                }
            }
            else
            {
                if (CostTextBox.Text != "")
                    CostTextBox.BackColor = Color.Red;
            }

        }

		///////////////////////////////////////////////////////////// Фильтрация и сортировка

		//Фильтер по имени
		private bool NameFilter(Item item)
        {
            if (FindTextBox.Text == null || FindTextBox.Text == "" || item.Name.Contains(FindTextBox.Text))
            {
                return true;
            }
            else return false;
        }

        //Работа поисковой строки
		private void FindTextBox_TextChanged(object sender, EventArgs e)
		{
            if (FindTextBox.Text != null && FindTextBox.Text != "")
            {
                //Фильтрация по имени
                _displayedItems = DataTools.Filter(Items, NameFilter);
            }
            else
            {
                _displayedItems = Items;                
            }

            //Сортировка итогого списка
			SortComboBox_SelectedIndexChanged(sender, e);			
		}

        //Сортировка по ID
        private bool IDSort(Item item1, Item item2)
        {
			if (item1.Id > item2.Id)
				return true;
			else return false;
		}

        //Сортировка по имени
        private bool NameSort(Item item1, Item item2)
        {
            int length;

            //Выбор длины по самому короткому
            if (item1.Name.Length > item2.Name.Length)
                length = item2.Name.Length;
            else length = item1.Name.Length;

            //Сравнение строк
            for (int i = 0; i < length; i++) 
            { 
                if (item1.Name[i] > item2.Name[i]) { return true; }
				if (item1.Name[i] < item2.Name[i]) { return false; }
			}

            //Одна строка подстрока другой
            if (item1.Name.Length > item2.Name.Length)
                return true;
            else return false;

		}

		//Сортировка по цене по возрастанию
		private bool CostAscendingSort(Item item1, Item item2)
		{
			if (item1.Cost > item2.Cost)
				return true;
			else return false;
		}

		//Сортировка по цене по убыванию
		private bool CostDescendingSort(Item item1, Item item2)
		{
			if (item1.Cost >= item2.Cost)
				return false;
			else return true;
		}

		//Сортировка
		private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

			switch (SortComboBox.SelectedIndex) 
            { 
                case 0:
                    _displayedItems = DataTools.Sort(_displayedItems, IDSort);
                    break;
                case 1:
					_displayedItems = DataTools.Sort(_displayedItems, NameSort);
					break;
				case 2:
					_displayedItems = DataTools.Sort(_displayedItems, CostAscendingSort);
					break;
				case 3:
					_displayedItems = DataTools.Sort(_displayedItems, CostDescendingSort);
					break;

			}

			UppdateListBox(_displayedItems);
		}


		///////////////////////////////////////////////////////////// Сброс выделения

		//Сброс выделения при нажатии клавиши в окне ItemsListBox
		private void ItemsListBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ItemsListBox.SelectedIndex = -1;
            ClearInputs();
        }

        //Сброс выделения при нажатии пкм
        private void ItemsListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ItemsListBox.SelectedIndex = -1;
                ClearInputs();
            }
        }
	}
}

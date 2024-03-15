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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        

        public ItemsTab()
        {
            InitializeComponent();
            // Инициализация Комбобокса категорий
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
        }

        //Нажатие на кнопку добавление
        //Добавляет обьект в список
        private void AddButton_Click(object sender, EventArgs e)
        {
            //Проверка пройденной валидации
            if (NameTextBox.BackColor != Color.Red && DescriptionTextBox.BackColor != Color.Red && CostTextBox.BackColor != Color.Red)
            {
                //Стоимость
                double bufferCost = double.Parse(CostTextBox.Text);
                //Что выделенно
                if (ItemsListBox.SelectedIndex != -1)
                {
                    //Выбранный обьект
                    Item selectedItem = (Item)ItemsListBox.SelectedItem;
                    int index = ItemsListBox.SelectedIndex;
                    //Изменение выбранного обьекта
                    selectedItem.Cost = bufferCost;
                    selectedItem.Name = NameTextBox.Text;
                    selectedItem.Info = DescriptionTextBox.Text;
                    ItemsListBox.Items[index] = selectedItem;
                }
                else
                {
                    //Создание нового обьекта
                    Item newItem = new Item(NameTextBox.Text, DescriptionTextBox.Text, bufferCost, (Category)CategoryComboBox.SelectedIndex);
                    ItemsListBox.Items.Add(newItem);
                }
            }
        }

        //Редактирование поля имени + валидация
        private void NameTextBox_Change(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Length > 0 && NameTextBox.Text.Length  <= 200)
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
            if (DescriptionTextBox.Text.Length > 0 && DescriptionTextBox.Text.Length <= 1000)
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
                if (bufferCost > 0 && bufferCost <= 100000)
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
                CostTextBox.BackColor = Color.Red;
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

        //Выбор обьекта
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                Item selectedItem = (Item)ItemsListBox.SelectedItem;
                //Заполнение полей
                IDTextBox.Text = selectedItem.Id.ToString();
                NameTextBox.Text = selectedItem.Name;
                DescriptionTextBox.Text = selectedItem.Info;
                CostTextBox.Text = selectedItem.Cost.ToString();
                CategoryComboBox.SelectedIndex = (int)selectedItem.Category;
            }
        }

        //Нажатие кнопки удаления
        //Удаляет выделенный обьект
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;
            if (index != -1)
            {
                ItemsListBox.Items.RemoveAt(index);
                ClearInputs();
            }
        }

        //Сброс выделения при нажатии клавиши в окне ItemsListBox
        private void ItemsListBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ItemsListBox.SelectedIndex = -1;
        }

        //Сброс выделения при нажатии пкм
        private void ItemsListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ItemsListBox.SelectedIndex = -1;
            }
        }
    }
}

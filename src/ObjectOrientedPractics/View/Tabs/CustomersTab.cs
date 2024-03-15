using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {

        public CustomersTab()
        {
            InitializeComponent();
        }

        //Нажатие кнопки добавления
        //Добавление обьекта
        //
        private void AddButton_Click(object sender, EventArgs e)
        {
            //Проверка на пройденную валидацию
            if (FullNameTextBox.BackColor != Color.Red)
            {
                //Проверка выделения
                if (CustomersListBox.SelectedIndex != -1)
                {
                    int index = CustomersListBox.SelectedIndex;
                    //Выбраный обьект
                    Customer selectedCustomer = (Customer)CustomersListBox.SelectedItem;
                    //Изменение обьекта
                    selectedCustomer.FullName = FullNameTextBox.Text;
                    selectedCustomer.Address = AddressControl.Address;
                    CustomersListBox.Items[index] = selectedCustomer;
                    
                }
                else
                {
                    //Добавление нового обьекта
                    Customer newCustomer = new Customer(FullNameTextBox.Text, AddressControl.Address);
                    CustomersListBox.Items.Add(newCustomer);
                }
            }
        }

        //Нажатие кнопки удаления
        //Удаляет выбранный обьект
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;
            if (index != -1)
            {
                CustomersListBox.Items.RemoveAt(index);
                CustomersListBox.SelectedIndex = -1;
                CustomersListBox_SelectedIndexChanged(sender,e);
            }
        }

        //Изменение поля имени + валидация
        private void FullNameTextBox_Change(object sender, EventArgs e)
        {
            if (FullNameTextBox.Text.Length > 0 && FullNameTextBox.Text.Length <= 200)
            {
                FullNameTextBox.BackColor = Color.White;
            }
            else
            {
                FullNameTextBox.BackColor = Color.Red;
            }

        }


        //Выделение обьекта в CustomersListBox
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                Customer selectedCustomer = (Customer)CustomersListBox.SelectedItem;
                IDTextBox.Text = selectedCustomer.Id.ToString();
                FullNameTextBox.Text = selectedCustomer.FullName;
                AddressControl.Address = selectedCustomer.Address;
            }
            else
            {
                IDTextBox.Text = "";
                FullNameTextBox.Text = "";
                AddressControl.Address = new Address();
            }
        }

        //Сброс выделения при нажатии клавиши в окне ItemsListBox
        private void ItemsListBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CustomersListBox.SelectedIndex = -1;
        }

        //Сброс выделения при нажатии пкм
        private void ItemsListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CustomersListBox.SelectedIndex = -1;
            }
        }
    }
}

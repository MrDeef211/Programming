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
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.View.Controls;
using ObjectOrientedPractics.View.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private static List<Customer> _customers = new List<Customer>();

        private List<IDiscount> _deletingDisconts = new List<IDiscount>();

        public static List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        public void UppdateListBox(List<Customer> newCustomer)
        {
            CustomersListBox.Items.Clear();
            CustomersListBox.SelectedIndex = -1;
            ClearInputs();
            for (int i = 0;  i < newCustomer.Count; i++)
            {
                CustomersListBox.Items.Add(newCustomer[i].FullName);
            }

        }

        public void ClearInputs()
        {

        }

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
                    selectedCustomer._isPriority = IsPriorityCheckBox.Checked;

                    //Удаление лишних скидок
                    foreach (var discont in _deletingDisconts)
                    {
                        selectedCustomer.Discounts.Remove(discont);
                    }
                    _deletingDisconts.Clear();

                    //Добавление новых скидок
                    for (int i = 0; i < DiscountsListBox.Items.Count; i++)
                    {
                        IDiscount discount = (IDiscount)DiscountsListBox.Items[i];
                        if (!selectedCustomer.Discounts.Contains(discount))
                        {
                            selectedCustomer.Discounts.Add(discount);
                        }
                    }

                    //ФИКСАЦИЯ ИЗМЕНЕНИЙ!!!!
                    //НЕ ПЕРЕСТАВЛЯТЬ!!!!
                    //НЕ ПИСАТЬ ИЗМЕНЕНИЯ ПОСЛЕ ФИКСАЦИИ!!!!
                    CustomersListBox.Items[index] = selectedCustomer;
                    Customers[index] = selectedCustomer;

                }
                else
                {
                    //Добавление нового обьекта
                    Customer newCustomer = new Customer(FullNameTextBox.Text, AddressControl.Address, IsPriorityCheckBox.Checked);

                    //Добавление скидок
                    for (int i = 0; i < DiscountsListBox.Items.Count; i++)
                    {
                        IDiscount discount = (IDiscount)DiscountsListBox.Items[i];
                        newCustomer.Discounts.Add(discount);
                    }

                    CustomersListBox.Items.Add(newCustomer);
                    Customers.Add(newCustomer);

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
                Customers.RemoveAt(index);
                CustomersListBox.SelectedIndex = -1;
                CustomersListBox_SelectedIndexChanged(sender,e);
            }
        }

        //Изменение поля имени + валидация
        private void FullNameTextBox_Change(object sender, EventArgs e)
        {
            if (FullNameTextBox.Text.Length <= 200)
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
            DiscountsListBox.Items.Clear();
            _deletingDisconts.Clear();
            if (CustomersListBox.SelectedIndex != -1)
            {
                Customer selectedCustomer = (Customer)CustomersListBox.SelectedItem;
                IDTextBox.Text = selectedCustomer.Id.ToString();
                FullNameTextBox.Text = selectedCustomer.FullName;
                AddressControl.Address = selectedCustomer.Address;
                IsPriorityCheckBox.Checked = selectedCustomer.IsPriority;
                foreach (IDiscount discount in selectedCustomer.Discounts)
                {
                    DiscountsListBox.Items.Add(discount);
                }
            }
            else
            {
                IDTextBox.Text = "";
                FullNameTextBox.Text = "";
                AddressControl.Address = new Address();
                IsPriorityCheckBox.Checked = false;
            }
        }

        //Сброс выделения при нажатии клавиши в окне ItemsListBox
        private void ItemsListBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CustomersListBox.SelectedIndex = -1;
            CustomersListBox_SelectedIndexChanged(sender, e);
        }

        //Сброс выделения при нажатии пкм
        private void ItemsListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CustomersListBox.SelectedIndex = -1;
                CustomersListBox_SelectedIndexChanged(sender, e);
            }
        }

        // Добавление скидки
        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            AddDiscountForm newDiscount = new AddDiscountForm();
            newDiscount.ShowDialog();
            if (newDiscount.confirm == true)
            {
                DiscountsListBox.Items.Add(new PercentDiscount(newDiscount.Category));

            }
        }

        //Удаление скидки
        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            if (DiscountsListBox.SelectedIndex > 0 ) 
            {
                if (CustomersListBox.SelectedIndex != -1)
                {
                    _deletingDisconts.Add((IDiscount)DiscountsListBox.SelectedItem);
                }
                DiscountsListBox.Items.Remove(DiscountsListBox.SelectedItem);

            }
        }




    }
}

using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Model.Discounts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{

    public partial class CartsTab : UserControl
    {
        private static List<Customer> _customers;
        private static List<Item> _items;

        private double _currentDiscont;

        public static List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        public static List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        private Customer CurrentCustomer
        {
            get
            {
                if (CustomerComboBox.SelectedIndex >= 0)
                {
                    return Customers[CustomerComboBox.SelectedIndex];
                }
                else return null;

            }
        }

        public CartsTab()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Обновление страницы
        /// </summary>
        public void UpdatePage()
        {
            //Обновление вещей
            ItemsListBox.Items.Clear();
            if (Items != null ) 
            { 
                foreach ( var item in Items ) 
                { 
                    ItemsListBox.Items.Add(item);
                }
            }

            // Обновление покупателей
            if ( Customers != null ) 
            {
                CustomerComboBox.DataSource = null;
                CustomerComboBox.DataSource = Customers;

            }

        }

        private void UpdateCart()
        {
            CartListBox.Items.Clear();
            if ( CurrentCustomer != null ) 
            { 
                //Список покупок
                foreach( var item in CurrentCustomer.Cart.Items) 
                { 
                    CartListBox.Items.Add(item);
                }
                AmountText.Text = CurrentCustomer.Cart.Amount.ToString();

                UpdateDiscont();
                
            }
            else
            {
                DiscountsCheckedListBox.Items.Clear();
                AmountText.Text = "0";
                DiscountAmmountText.Text = "0";
                TotalText.Text = "0";
            }
        }

        //Обновление скидки
        private void UpdateDiscont()
        {
            _currentDiscont = 0;
            //Подсчёт общей скидки
            for (int i = 0; i < DiscountsCheckedListBox.Items.Count; i++)
            {
                if (DiscountsCheckedListBox.GetItemChecked(i))
                {
                    _currentDiscont += CurrentCustomer.Discounts[i].Calculate(CurrentCustomer.Cart.Items);
                }
            }

            DiscountAmmountText.Text = _currentDiscont.ToString();
            TotalText.Text = (CurrentCustomer.Cart.Amount - _currentDiscont).ToString();
        }

        //Обновление скидок
        private void UpdateDiscontsList()
        {
            //Список скидок
            DiscountsCheckedListBox.Items.Clear();
            foreach (var discount in CurrentCustomer.Discounts)
            {
                DiscountsCheckedListBox.Items.Add(discount);
            }

            //Галки рядом со скидками
            for (int i = 0; i < DiscountsCheckedListBox.Items.Count; i++)
            {
                DiscountsCheckedListBox.SetItemChecked(i, true);
            }
        }

        //Изменение пользователя
        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( CustomerComboBox.SelectedIndex != -1 )
            {
                UpdateCart();

                UpdateDiscontsList();

            }
            else
            {
                CartListBox.Items.Clear();
                UpdateCart();
            }

        }

        //Добавление элемента в корзину
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex != -1 && ItemsListBox.SelectedIndex != -1)
            {
                CurrentCustomer.Cart.Items.Add((Item)ItemsListBox.SelectedItem);
                UpdateCart();
            }
        }

        //Удаление элемента из корзины
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex != -1 && ItemsListBox.SelectedIndex != -1 && CartListBox.SelectedIndex != -1)
            {
                CurrentCustomer.Cart.Items.Remove((Item)CartListBox.SelectedItem);
                UpdateCart();
            }
        }

        //Очистка корзины
        private void ClearButton_Click(object sender, EventArgs e)
        {

            CurrentCustomer.Cart.Items.Clear();
            UpdateCart();

        }

        //Создание заказа
        private void CreateButton_Click(object sender, EventArgs e)
        {
            //Проверка наличия покупок в корзине
            if(CartListBox.Items.Count == 0)
            {
                return;
            }
            //Итоговая цена
            double discont = 0;

            //Фиксация бонусов и подсчёт скидки
            for (int i = 0; i < DiscountsCheckedListBox.Items.Count; i++)
            {
                if (DiscountsCheckedListBox.GetItemChecked(i))
                {
                    discont += CurrentCustomer.Discounts[i].Apply(CurrentCustomer.Cart.Items);
                }
                CurrentCustomer.Discounts[i].Update(CurrentCustomer.Cart.Items);
            }

            //Проверка приоритета покупателя
            if (CurrentCustomer._isPriority)
            {
                CurrentCustomer.Orders.Add(new PriorityOrder(CurrentCustomer.Address, CurrentCustomer.Cart.Items, CurrentCustomer.Cart.Amount, discont, OrderStatus.New));
            }
            else
            {
                CurrentCustomer.Orders.Add(new Order(CurrentCustomer.Address, CurrentCustomer.Cart.Items, CurrentCustomer.Cart.Amount, discont, OrderStatus.New));
            }
            ClearButton_Click(sender, e);
            UpdateDiscontsList();
        }

        //Сброс выделения при нажатии клавиши
        private void ItemsListBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ItemsListBox.SelectedIndex = -1;
            CustomerComboBox.SelectedIndex = -1;
            CartListBox.SelectedIndex = -1;
        }

        //Сброс выделения при нажатии пкм
        private void ItemsListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ItemsListBox.SelectedIndex = -1;
            }
        }

        //Сброс выделения при нажатии пкм
        private void CustomerComboBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CustomerComboBox.SelectedIndex = -1;
            }
        }

        //Сброс выделения при нажатии пкм
        private void CartListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CartListBox.SelectedIndex = -1;
            }
        }

        private void DiscountsCheckedListBox_Click(object sender, EventArgs e)
        {
            UpdateDiscont();
        }
    }
}

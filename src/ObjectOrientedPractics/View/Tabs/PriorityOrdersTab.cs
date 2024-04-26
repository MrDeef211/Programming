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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class PriorityOrdersTab : UserControl
    {
        private PriorityOrder _order;
        private static List<Item> _items = new List<Item>();

        public PriorityOrder Order
        {
            set { _order = value; }
            get { return _order; }
        }

        public static List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public PriorityOrdersTab()
        {
            InitializeComponent();
            Order = new PriorityOrder();
            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            DeliveryTimeComboBox.DataSource = PriorityOrder.DeliveryTimes;
        }

        /// <summary>
        /// Обновление страницы
        /// </summary>
        public void UpdatePage()
        {
            //Обновление вещей
            ItemsListBox.Items.Clear();
            if (Items != null)
            {
                foreach (var item in Items)
                {
                    ItemsListBox.Items.Add(item);
                }
            }
            IDTextBox.Text = Order.Id.ToString();
            DataTextBox.Text = Order.Date.ToString();
        }

        //Добавление элемента в заказ
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                ItemListBox.Items.Add((Item)ItemsListBox.SelectedItem);
                Order.Items.Add((Item)ItemsListBox.SelectedItem);
            }
        }

        //Удаление элемента из заказа
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                ItemListBox.Items.Remove((Item)ItemListBox.SelectedItem);
                Order.Items.Remove((Item)ItemsListBox.SelectedItem);
            }
        }

        //Очистка заказа
        private void ClearButton_Click(object sender, EventArgs e)
        {

            ItemListBox.Items.Clear();
            Order = new PriorityOrder();
            UpdatePage();

        }

    }
}

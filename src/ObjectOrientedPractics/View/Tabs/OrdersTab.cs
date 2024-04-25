using System;
using ObjectOrientedPractics.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        private static List<Order> _orders;

        private static List<Order> Orders
        {
            get { return _orders; }
            set 
            { _orders = value; }
        }

        //Изьятие заказов из покупателей
        public static List<Customer> Customers
        {
            set
            {
                Orders.Clear();
                foreach (Customer thisCustomer in value) 
                { 
                    // наличие заказов
                    if (thisCustomer.Orders != null) 
                    {
                        //Перенос заказов
                        foreach (Order thisOrder in thisCustomer.Orders)
                        {
                            Orders.Add(new Order(thisOrder.Id, thisOrder.Date, thisOrder.Address, thisOrder.Cost, thisOrder.Status, thisCustomer, thisOrder.Items));
                        }
                    }

                }
            }
        }

        public OrdersTab()
        {
            InitializeComponent();
            Orders = new List<Order>();
            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
        }

        /// <summary>
        /// Обновление страницы
        /// </summary>
        public void UpdatePage()
        {
            if (Orders != null)
            {
                OrdersGridView.DataSource = null;
                OrdersGridView.DataSource = Orders;

            }
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdersGridView.CurrentCell != null && OrdersGridView.CurrentCell.RowIndex != -1)
            {
                Orders[OrdersGridView.CurrentCell.RowIndex].Status = (OrderStatus)StatusComboBox.SelectedItem;
                UpdatePage();
            }
        }

        private void OrdersGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Order currentOrder = Orders[OrdersGridView.CurrentCell.RowIndex];
            IDTextBox.Text = currentOrder.Id.ToString();
            DataTextBox.Text = currentOrder.Date.ToString();
            StatusComboBox.SelectedItem = currentOrder.Status;
            AddressControl.Address = currentOrder.Address;
            ItemListBox.Items.Clear();
            foreach (Item thisitem in currentOrder.Items)
            {
                ItemListBox.Items.Add(thisitem);
            }

        }
    }
}

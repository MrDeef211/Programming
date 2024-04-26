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
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        private static List<Order> _orders;
        private Order _selectedOrder;
        private PriorityOrder _selectedPriorityOrder;

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
                foreach (Customer thisCustomer in value) 
                { 
                    // наличие заказов
                    if (thisCustomer.Orders != null) 
                    {
                        //Перенос заказов
                        foreach (var thisOrder in thisCustomer.Orders)
                        {
                            
                            bool skip = false;
                            //Проверка существующих заказов по индексу
                            foreach (var O in Orders)
                            {
                                if (O.Id == thisOrder.Id)
                                {
                                    //Пропуск существующего заказа
                                    skip = true;
                                    break;
                                }
                            }

                            //Пропуск существующего заказа
                            if (skip)
                            {
                                continue;
                            }


                            if (thisOrder is PriorityOrder priority)
                            {
                                Orders.Add(new PriorityOrder(thisOrder.Id, thisOrder.Date, thisOrder.Address, thisOrder.Cost, thisOrder.DiscountAmount, thisOrder.Status, thisCustomer, thisOrder.Items));
                            }
                            else
                            {
                                Orders.Add(new Order(thisOrder.Id, thisOrder.Date, thisOrder.Address, thisOrder.Cost, thisOrder.DiscountAmount, thisOrder.Status, thisCustomer, thisOrder.Items));
                            }

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
            DeliveryTimeComboBox.DataSource = PriorityOrder.DeliveryTimes;
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
            if (_selectedOrder != null)
            {
                _selectedOrder.Status = (OrderStatus)StatusComboBox.SelectedItem;
                UpdatePage();
            }
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedPriorityOrder != null && DeliveryTimeComboBox.SelectedItem != null)
            {
                _selectedPriorityOrder.DeliveryTime = DeliveryTimeComboBox.SelectedItem.ToString();
                UpdatePage();
            }
        }

        private void OrdersGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _selectedOrder = Orders[OrdersGridView.CurrentCell.RowIndex];

            //Проверка приоритета
            if (Orders[OrdersGridView.CurrentCell.RowIndex] is PriorityOrder priority)
            {
                _selectedPriorityOrder = (PriorityOrder)Orders[OrdersGridView.CurrentCell.RowIndex];
                PriorityPanel.Visible = true;
                DeliveryTimeComboBox.SelectedItem = _selectedPriorityOrder.DeliveryTime;
            }
            else
            {
                _selectedPriorityOrder = null;
                PriorityPanel.Visible = false;
            }

            IDTextBox.Text = _selectedOrder.Id.ToString();
            DataTextBox.Text = _selectedOrder.Date.ToString();
            StatusComboBox.SelectedItem = _selectedOrder.Status;
            AddressControl.Address = _selectedOrder.Address;
            ItemListBox.Items.Clear();
            foreach (Item thisitem in _selectedOrder.Items)
            {
                ItemListBox.Items.Add(thisitem);
            }

        }


    }
}

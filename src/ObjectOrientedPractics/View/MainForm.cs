using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View
{
    public partial class MainForm : Form
    {
        private Store _store;
        public MainForm()
        {
            InitializeComponent();
            _store = new Store();

            CustomersTab.Customers = _store.Customers;
            CartsTab.Customers = _store.Customers;
            ItemsTab.Items = _store.Items;
            CartsTab.Items = _store.Items;
            OrdersTab.Customers = _store.Customers;

            ItemsTab.ItemsChanged += ItemsTab_ItemsChanged;

            CustomersTab.CustomerChanged += ItemsTab_ItemsChanged;

        }

        //Обновление предметов в других окнах
        private void ItemsTab_ItemsChanged(object sender, EventArgs e)
        {
            _store.Items = ItemsTab.Items;

            CartsTab.Items = _store.Items;
            cartsTab1.UpdatePage();

        }

        //Обновление пользователей в других окнах
        private void CustomerTab_CustomersChanged(object sender, EventArgs e)
        {
            _store.Customers = CustomersTab.Customers;

            CartsTab.Customers = _store.Customers;
            cartsTab1.UpdatePage();

            OrdersTab.Customers = _store.Customers;
            ordersTab.UpdatePage();
        }

	}
}

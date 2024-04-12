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


        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            CartsTab.Items = _store.Items;
            CartsTab.Customers = _store.Customers;
            cartsTab1.UpdatePage();
        }

        private void tabPage1_Leave(object sender, EventArgs e)
        {
            _store.Items = ItemsTab.Items;
        }

        private void tabPage2_Leave(object sender, EventArgs e)
        {
            _store.Customers = CustomersTab.Customers;
        }

        private void Orders_Enter(object sender, EventArgs e)
        {
            OrdersTab.Customers = _store.Customers;
            ordersTab.UpdatePage();
        }

        private void Orders_Leave(object sender, EventArgs e)
        {
            _store.Customers = CartsTab.Customers;
        }
    }
}

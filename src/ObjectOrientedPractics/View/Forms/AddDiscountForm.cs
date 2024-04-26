using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Forms
{
    public partial class AddDiscountForm : Form
    {
        //Выбранная категория
        private Category _category;
        //Окно закрыто через Ok
        public bool confirm = false;

        /// <summary>
        /// Выбранная категория
        /// </summary>
        public Category Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public AddDiscountForm()
        {
            InitializeComponent();
            CategoryComboBox.DataSource =  Enum.GetValues(typeof(Category));
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedIndex != -1) 
            {
                Category = (Category)CategoryComboBox.SelectedItem;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            confirm = true;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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

namespace ObjectOrientedPractics.View.Tabs
{
	public partial class Test_6 : UserControl
	{
		private static List<Customer> _customers;
		private static List<Item> _items;

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


		public Test_6()
		{
			InitializeComponent();

		}

		private void button1_Click(object sender, EventArgs e)
		{
			//Копирование 
			Item item1 = (Item)Items[0].Clone();
			Item item2 = (Item)Items[1].Clone();

			Address address1 = (Address)Customers[0].Address.Clone();
			Address address2 = (Address)Customers[1].Address.Clone();

			//Проверка равенства
			bool res1 = item1.Equals(item2);
			label3.Text = res1.ToString();

			bool res2 = address1.Equals(address2);
			label6.Text = res2.ToString();

			bool res3 = Customers[0].Orders[0].Equals(Customers[1].Orders[0]);
			label9.Text = res3.ToString();

			// Сравнение 
			int res4 = item1.CompareTo(item2);
			switch(res4)
			{
				case -1:
					label12.Text = "<";
					break;
				case 0:
					label12.Text = "==";
					break;
				case 1:
					label12.Text = ">";	
					break;

			}

			int res5 = Customers[0].Discounts[0].CompareTo(Customers[1].Discounts[0]);
			switch (res5)
			{
				case -1:
					label15.Text = "<";
					break;
				case 0:
					label15.Text = "==";
					break;
				case 1:
					label15.Text = ">";
					break;

			}

			int res6 = Customers[0].Discounts[1].CompareTo(Customers[1].Discounts[1]);
			switch (res6)
			{
				case -1:
					label17.Text = "<";
					break;
				case 0:
					label17.Text = "==";
					break;
				case 1:
					label17.Text = ">";
					break;

			}
		}
	}
}

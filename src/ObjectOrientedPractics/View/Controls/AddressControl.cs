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
using ObjectOrientedPractics.Servises;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        public AddressControl()
        {
            InitializeComponent();
            WrongInputLabel.Text = "";

        }

        /// <summary>
        /// Создание нового экземпляра класса
        /// </summary>
        private Address _address = new Address();

        /// <summary>
        /// Свойство для адреса
        /// </summary>
        public Address Address
        {
            set
            {
                _address = value;
                UpdateTextBoxes();
            }
            get
            { 
                return _address; 
            }
        }

        /// <summary>
        /// Обновляет данные текстовых полей ввода.
        /// </summary>
        private void UpdateTextBoxes()
        {

            PostIndexTextBox.Text = Address.Index.ToString();
            CountryTextBox.Text = Address.Country;
            CityTextBox.Text = Address.City;
            StreetTextBox.Text = Address.Street;
            BuildingTextBox.Text = Address.Building;
            ApartmentTextBox.Text = Address.Apartment;

        }

        //Изменение поля индекса
        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PostIndexTextBox.Text.Length == 6 & int.TryParse(PostIndexTextBox.Text, out var temp))
            {
                PostIndexTextBox.BackColor = Color.White;
                WrongInputLabel.Text = "";
            }
            else
            {
                PostIndexTextBox.BackColor = Color.Red;
                WrongInputLabel.Text = "Post Index must have 6 symbols.";
            }
        }

        //Изменение поля cтраны
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CountryTextBox.Text.Length <= 50)
            {
                CountryTextBox.BackColor = Color.White;
                WrongInputLabel.Text = "";
            }
            else
            {
                CountryTextBox.BackColor = Color.Red;
                WrongInputLabel.Text = "Country must have less 50 symbols.";
            }
        }

        //Изменение поля город
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CityTextBox.Text.Length <= 50)
            {
                CityTextBox.BackColor = Color.White;
                WrongInputLabel.Text = "";
            }
            else
            {
                CityTextBox.BackColor = Color.Red;
                WrongInputLabel.Text = "City must have less 50 symbols.";
            }
        }

        //Изменение поля улицы
        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (StreetTextBox.Text.Length <= 100)
            {
                StreetTextBox.BackColor = Color.White;
                WrongInputLabel.Text = "";
            }
            else
            {
                StreetTextBox.BackColor = Color.Red;
                WrongInputLabel.Text = "Street must have less 100 symbols.";
            }
        }

        //Изменение поля дома
        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (BuildingTextBox.Text.Length <= 10)
            {
                BuildingTextBox.BackColor = Color.White;
                WrongInputLabel.Text = "";
            }
            else
            {
                BuildingTextBox.BackColor = Color.Red;
                WrongInputLabel.Text = "Building must have less 10 symbols.";
            }
        }

        //Изменение поля квартиры
        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ApartmentTextBox.Text.Length <= 10)
            {
                ApartmentTextBox.BackColor = Color.White;
                WrongInputLabel.Text = "";
            }
            else
            {
                ApartmentTextBox.BackColor = Color.Red;
                WrongInputLabel.Text = "Apartment must have less 10 symbols.";
            }
        }

        //Ввод данных при покидании поля
        private void PostIndexTextBox_Leave(object sender, EventArgs e)
        {

            if (PostIndexTextBox.BackColor == Color.White)
            {
                Address.Index = int.Parse(PostIndexTextBox.Text);
            }
        }

        //Ввод данных при покидании поля
        private void CountryTextBox_Leave(object sender, EventArgs e)
        {
            if (CountryTextBox.BackColor == Color.White)
            {
                Address.Country = CountryTextBox.Text;
            }
        }

        //Ввод данных при покидании поля
        private void CityTextBox_Leave(object sender, EventArgs e)
        {

            if (CityTextBox.BackColor == Color.White)
            {
                Address.City = CityTextBox.Text;
            }
        }

        //Ввод данных при покидании поля
        private void StreetTextBox_Leave(object sender, EventArgs e)
        {
            if (StreetTextBox.BackColor == Color.White)
            {
                Address.Street = StreetTextBox.Text;
            }
        }

        //Ввод данных при покидании поля
        private void BuildingTextBox_Leave(object sender, EventArgs e)
        {
            if (BuildingTextBox.BackColor == Color.White)
            {
                Address.Building = BuildingTextBox.Text;
            }
        }

        //Ввод данных при покидании поля
        private void ApartmentTextBox_Leave(object sender, EventArgs e)
        {
            if (ApartmentTextBox.BackColor == Color.White)
            {
                Address.Apartment = ApartmentTextBox.Text;
            }
        }
    }
}

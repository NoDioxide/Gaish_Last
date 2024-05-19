using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gaish_4_step
{
    public partial class Main : Form
    {
        private bool label9Clicked = false;
        private bool label10Clicked = false;
        private bool label11Clicked = false;
        private bool label12Clicked = false;

        int price = 0;

        public Main()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            comboBoxColor.SelectedIndexChanged += new EventHandler(FieldChanged);
            comboBoxShipType.SelectedIndexChanged += new EventHandler(FieldChanged);
            comboBoxMastHas.SelectedIndexChanged += new EventHandler(FieldChanged);
            comboBoxWoodTypes.SelectedIndexChanged += new EventHandler(FieldChanged);
            textBoxProductName.TextChanged += new EventHandler(FieldChanged);
            textBoxBasePrice.TextChanged += new EventHandler(FieldChanged);
            textBoxRowerCapacity.TextChanged += new EventHandler(FieldChanged);
        }

        private void FieldChanged(object sender, EventArgs e)
        {
            CheckAllFieldsFilled();
        }

        private void CheckAllFieldsFilled()
        {
            bool allFieldsFilled = comboBoxColor.SelectedIndex != -1 &&
                                   comboBoxShipType.SelectedIndex != -1 &&
                                   comboBoxMastHas.SelectedIndex != -1 &&
                                   comboBoxWoodTypes.SelectedIndex != -1 &&
                                   !string.IsNullOrWhiteSpace(textBoxProductName.Text) &&
                                   !string.IsNullOrWhiteSpace(textBoxBasePrice.Text) &&
                                   !string.IsNullOrWhiteSpace(textBoxRowerCapacity.Text);

            btnToPay.Visible = allFieldsFilled;
        }

        public void UpdateVisibility(bool loginSuccessful)
        {
            if (loginSuccessful)
            {
                label1.Visible = false;
                lbltolog.Visible = false;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                label19.Visible = false;
            }
        }

        private void lbltolog_Click(object sender, EventArgs e)
        {
            Login login = new Login(this);
            this.Hide();
            login.ShowDialog();
            this.Show();
        }

        private void VisibleTrue()
        {
            label14.Visible = true;
            labelProductName.Visible = true;
            textBoxProductName.Visible = true;
            labelBasePrice.Visible = true;
            textBoxBasePrice.Visible = true;
            labelColor.Visible = true;
            comboBoxColor.Visible = true;
            labelShipType.Visible = true;
            comboBoxShipType.Visible = true;
            labelRowerCapacity.Visible = true;
            textBoxRowerCapacity.Visible = true;
            labelWoodTypes.Visible = true;
            comboBoxWoodTypes.Visible = true;
            labelMastHas.Visible = true;
            comboBoxMastHas.Visible = true; 
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox3.Visible = true;
            checkBox4.Visible = true;
            checkBox5.Visible = true;
            checkBox6.Visible = true;
            checkBox7.Visible = true;
            buttonSave.Visible = true;
        }

        private void VisibleFalse()
        {
            label1.Visible = false;
            lbltolog.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label14.Visible = false;
            labelProductName.Visible = false;
            textBoxProductName.Visible = false;
            labelBasePrice.Visible = false;
            textBoxBasePrice.Visible = false;
            labelColor.Visible = false;
            comboBoxColor.Visible = false;
            labelShipType.Visible = false;
            comboBoxShipType.Visible = false;
            labelRowerCapacity.Visible = false;
            textBoxRowerCapacity.Visible = false;
            labelWoodTypes.Visible = false;
            comboBoxWoodTypes.Visible = false;
            labelMastHas.Visible = false;
            comboBoxMastHas.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            checkBox5.Visible = false;
            checkBox6.Visible = false;
            checkBox7.Visible = false;
            buttonSave.Visible = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            VisibleTrue();
            label9Clicked = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            VisibleTrue();
            label10Clicked = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            VisibleTrue();
            label11Clicked = true;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            VisibleTrue();
            label12Clicked = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (label9Clicked)
            {
                price = CalculatePrice(600000);
            }
            else if (label10Clicked)
            {
                price = CalculatePrice(460000);
            }
            else if (label11Clicked)
            {
                price = CalculatePrice(3400000);
            }
            else if (label12Clicked)
            {
                price = CalculatePrice(700000);
            }

            textBoxBasePrice.Text = price.ToString();
        }

        private int CalculatePrice(int basePrice)
        {
            int price = basePrice;

            if (comboBoxColor.SelectedIndex >= 0 && comboBoxColor.SelectedIndex <= 5)
            {
                price += 10000;
            }

            int RowerCap = 0;
            if (comboBoxShipType.SelectedIndex >= 0 && comboBoxShipType.SelectedIndex <= 2)
            {
                if (comboBoxShipType.SelectedIndex == 0)
                {
                    RowerCap = 4;
                    price += 70000;
                }
                else if (comboBoxShipType.SelectedIndex == 1)
                {
                    RowerCap = 1;
                    price += 140000;
                }
                else if (comboBoxShipType.SelectedIndex == 2)
                {
                    RowerCap = 200;
                    price += 210000;
                }
                textBoxRowerCapacity.Text = RowerCap.ToString();
            }

            if (comboBoxMastHas.SelectedIndex >= 0 && comboBoxMastHas.SelectedIndex <= 1)
            {
                price += 10000;
            }

            if (comboBoxWoodTypes.SelectedIndex >= 0 && comboBoxWoodTypes.SelectedIndex <= 4)
            {
                price += 10000;
            }

            if (checkBox1.Checked) price += 10000;
            if (checkBox2.Checked) price += 10000;
            if (checkBox3.Checked) price += 10000;
            if (checkBox4.Checked) price += 10000;
            if (checkBox5.Checked) price += 10000;
            if (checkBox6.Checked) price += 10000;
            if (checkBox7.Checked) price += 10000;

            return price;
        }

        private void btnToPay_Click(object sender, EventArgs e)
        {
            VisibleFalse();
            btnToPay.Visible = false;
            label13.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
            textBoxTotalPrice.Visible = true;
            btnPay.Visible = true;

            int totalPrice = price + 35000;
            textBoxTotalPrice.Text = totalPrice.ToString();
        }

        private void labelEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            this.Hide();
            reg.ShowDialog();
            this.Show();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            label13.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = true;
            textBoxTotalPrice.Visible = false;
            btnPay.Visible = false;

            InsertOrderIntoDatabase();
        }

        private void InsertOrderIntoDatabase()
        {
            string connectionString = @"Data Source=DESKTOP-7QTLDNV\SQLEXPRESS;Initial Catalog=Gaish_4_step;Integrated Security=True";
            int totalPrice = int.Parse(textBoxTotalPrice.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO ship_orders (ProductName, ShipType, RowerCapacity, WoodTypes, Color, MastHas, BasePrice, OrderProcess) " +
                               "VALUES (@ProductName, @ShipType, @RowerCapacity, @WoodTypes, @Color, @MastHas, @BasePrice, @OrderProcess)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", textBoxProductName.Text);
                    command.Parameters.AddWithValue("@ShipType", comboBoxShipType.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@RowerCapacity", textBoxRowerCapacity.Text);
                    command.Parameters.AddWithValue("@WoodTypes", comboBoxWoodTypes.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@Color", comboBoxColor.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@MastHas", comboBoxMastHas.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@BasePrice", totalPrice);
                    command.Parameters.AddWithValue("@OrderProcess", "Работы не начаты");

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

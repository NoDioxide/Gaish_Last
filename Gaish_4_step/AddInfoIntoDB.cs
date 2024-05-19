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
    public partial class AddInfoIntoDB : Form
    {

        DataBase database = new DataBase();

        public AddInfoIntoDB()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var ProductName = textBoxProductName.Text;
            var ShipType = comboBoxShipType.Text;
            var RowerCapacity = textBoxRowerCapacity.Text;
            var WoodTypes = comboBoxWoodTypes.Text;
            var Color = comboBoxColor.Text;
            var OrderProcess = comboBoxProcess.Text;
            var MastHas = comboBoxMastHas.Text;
            int BasePrice;

            // Убедитесь, что BasePrice обновляется в зависимости от значения OrderProcess
            if (OrderProcess == "Проезд на красный цвет")
            {
                BasePrice = 1500;
            }
            else if (OrderProcess == "Проезд через сплошную")
            {
                BasePrice = 1000;
            }
            else
            {
                // Если значение OrderProcess не совпадает с известными значениями, проверьте поле BasePrice
                if (!int.TryParse(textBoxBasePrice.Text, out BasePrice))
                {
                    MessageBox.Show("Ошибка: Цена должна быть числом.");
                    return;
                }
            }

            var addQuery = "insert into ship_orders (ProductName, ShipType, RowerCapacity, WoodTypes, Color, OrderProcess, BasePrice, MastHas) " +
                           "values (@ProductName, @ShipType, @RowerCapacity, @WoodTypes, @Color, @OrderProcess, @BasePrice, @MastHas)";

            using (var command = new SqlCommand(addQuery, database.GetConnection()))
            {
                command.Parameters.AddWithValue("@ProductName", ProductName);
                command.Parameters.AddWithValue("@ShipType", ShipType);
                command.Parameters.AddWithValue("@RowerCapacity", RowerCapacity);
                command.Parameters.AddWithValue("@WoodTypes", WoodTypes);
                command.Parameters.AddWithValue("@Color", Color);
                command.Parameters.AddWithValue("@OrderProcess", OrderProcess);
                command.Parameters.AddWithValue("@BasePrice", BasePrice);
                command.Parameters.AddWithValue("@MastHas", MastHas);

                command.ExecuteNonQuery();
            }

            MessageBox.Show("Запись создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            database.closeConnection();
        }

        private void labelEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxEraser_Click(object sender, EventArgs e)
        {

        }
    }
}

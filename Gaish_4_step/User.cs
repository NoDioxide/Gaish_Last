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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gaish_4_step
{
    public partial class User : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DEKSTOP-ND\SQLEXPRESS;Initial Catalog=Gaish_4_step;Integrated Security=True");

        public User()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void buttonToTB_Click(object sender, EventArgs e)
        {
            string data1 = textBoxCarNumber.Text;
            string data2 = textBoxLastName.Text;
            string data3 = textBoxFirstName.Text;
            string data4 = textBoxPatron.Text;

            string connectionString = "Data Source=DEKSTOP-ND\\SQLEXPRESS;Initial Catalog=Gaish_4_step;Integrated Security=True";
            string query = "SELECT * FROM violations WHERE CarNumber = @CarNumber AND LastName = @LastName AND FirstName = @FirstName AND Patronymic = @Patronymic";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CarNumber", data1);
                    command.Parameters.AddWithValue("@LastName", data2);
                    command.Parameters.AddWithValue("@FirstName", data3);
                    command.Parameters.AddWithValue("@Patronymic", data4);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            StringBuilder resultData = new StringBuilder();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                resultData.Append($"{reader.GetName(i)}: {reader[i].ToString()}\r\n");
                            }

                            textBoxResult.Text = resultData.ToString();

                            buttonToPay.Visible = true;
                            groupBox1.Visible = true;
                            labelEXIT.Visible = false;
                        }
                        else
                        {
                            textBoxResult.Text = "Данные не найдены!";
                            buttonToPay.Visible = false;
                            groupBox1.Visible = false;
                        }
                    }
                }
            }
        }

        private void pictureBoxEraser_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            buttonToPay.Visible = false;
            groupBox1.Visible = false;
            labelEXIT.Visible = true;
        }

        private void buttonToPay_Click(object sender, EventArgs e)
        {
            Payment paymentform = new Payment();

            string[] resultLines = textBoxResult.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            if (resultLines.Length > 0)
            {
                string carNumber = textBoxCarNumber.Text;
                string lastName = textBoxLastName.Text;
                string firstName = textBoxFirstName.Text;
                string patron = textBoxPatron.Text;

                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                using (SqlCommand sqlCommand = new SqlCommand("DELETE FROM violations WHERE CarNumber = @CarNumber AND LastName = @LastName AND FirstName = @FirstName AND Patronymic = @Patronymic", sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@CarNumber", carNumber);
                    sqlCommand.Parameters.AddWithValue("@LastName", lastName);
                    sqlCommand.Parameters.AddWithValue("@FirstName", firstName);
                    sqlCommand.Parameters.AddWithValue("@Patronymic", patron);

                    int rowsAffected = sqlCommand.ExecuteNonQuery();
                }

                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
            this.Hide();
            paymentform.ShowDialog();
            this.Show();
        }

        private void textBoxLastName_Enter(object sender, EventArgs e)
        {
            if (textBoxLastName.Text == "Фамилия")
            {
                textBoxLastName.Text = "";

                textBoxLastName.ForeColor = Color.Black;
            }
        }

        private void textBoxLastName_Leave(object sender, EventArgs e)
        {
            if (textBoxLastName.Text == "")
            {
                textBoxLastName.Text = "Фамилия";

                textBoxLastName.ForeColor = Color.Silver;
            }
        }

        private void textBoxFirstName_Enter(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "Имя")
            {
                textBoxFirstName.Text = "";

                textBoxFirstName.ForeColor = Color.Black;
            }
        }

        private void textBoxFirstName_Leave(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "")
            {
                textBoxFirstName.Text = "Имя";

                textBoxFirstName.ForeColor = Color.Silver;
            }
        }

        private void textBoxPatron_Enter(object sender, EventArgs e)
        {
            if (textBoxPatron.Text == "Отчество")
            {
                textBoxPatron.Text = "";

                textBoxPatron.ForeColor = Color.Black;
            }
        }

        private void textBoxPatron_Leave(object sender, EventArgs e)
        {
            if (textBoxPatron.Text == "")
            {
                textBoxPatron.Text = "Отчество";

                textBoxPatron.ForeColor = Color.Silver;
            }
        }

        private void textBoxCarNumber_Enter(object sender, EventArgs e)
        {
            if (textBoxCarNumber.Text == "Номер автомобиля")
            {
                textBoxCarNumber.Text = "";

                textBoxCarNumber.ForeColor = Color.Black;
            }
        }

        private void textBoxCarNumber_Leave(object sender, EventArgs e)
        {
            if (textBoxCarNumber.Text == "")
            {
                textBoxCarNumber.Text = "Номер автомобиля";

                textBoxCarNumber.ForeColor = Color.Silver;
            }
        }

        private void labelEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelEXIT_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

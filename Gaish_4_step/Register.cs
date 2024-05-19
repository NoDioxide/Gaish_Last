using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gaish_4_step
{
    public partial class Register : Form
    {
        private Main mainForm;
        private SqlConnection sqlConnection;

        public Register()
        {
            InitializeComponent();
            InitializeCustomComponents();
            sqlConnection = new SqlConnection(@"Data Source=DESKTOP-7QTLDNV\SQLEXPRESS;Initial Catalog=Gaish_4_step;Integrated Security=True");
        }

        private void InitializeCustomComponents()
        {
            UserButtonLReg.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;

            radioButton1.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);

            UserTB.TextChanged += new EventHandler(TextFields_TextChanged);
            PasswordTB.TextChanged += new EventHandler(TextFields_TextChanged);
            textBox1.TextChanged += new EventHandler(TextFields_TextChanged);
            textBox2.TextChanged += new EventHandler(TextFields_TextChanged);
            textBox3.TextChanged += new EventHandler(TextFields_TextChanged);
            textBox4.TextChanged += new EventHandler(TextFields_TextChanged);
            textBox5.TextChanged += new EventHandler(TextFields_TextChanged);
            textBox10.TextChanged += new EventHandler(TextFields_TextChanged);
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox6.Visible = true;
                textBox7.Visible = false;
                label6.Visible = true;
            }
            else if (radioButton2.Checked)
            {
                textBox6.Visible = false;
                textBox7.Visible = true;
                label6.Visible = true;
            }
        }

        private void TextFields_TextChanged(object sender, EventArgs e)
        {
            UserButtonLReg.Visible = AreAllTextFieldsFilled();
        }

        private bool AreAllTextFieldsFilled()
        {
            return !string.IsNullOrWhiteSpace(UserTB.Text) &&
                   !string.IsNullOrWhiteSpace(PasswordTB.Text) &&
                   !string.IsNullOrWhiteSpace(textBox1.Text) &&
                   !string.IsNullOrWhiteSpace(textBox2.Text) &&
                   !string.IsNullOrWhiteSpace(textBox3.Text) &&
                   !string.IsNullOrWhiteSpace(textBox4.Text) &&
                   !string.IsNullOrWhiteSpace(textBox5.Text) &&
                   !string.IsNullOrWhiteSpace(textBox10.Text);
        }

        private void SaveDataToDatabase()
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO register_USR (login_user, password_user) VALUES (@Username, @Password)", sqlConnection))
            {
                command.Parameters.AddWithValue("@Username", UserTB.Text);
                command.Parameters.AddWithValue("@Password", PasswordTB.Text);

                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        private void UserButtonLReg_Click(object sender, EventArgs e)
        {
            if (AreAllTextFieldsFilled())
            {
                SaveDataToDatabase();
                Main main = new Main();
                this.Hide();
                main.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

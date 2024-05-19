using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gaish_4_step
{
    public partial class Login : Form
    {

        DataBase database = new DataBase();
        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            this.PasswordTB.AutoSize = false;
            this.PasswordTB.Size = new Size(this.PasswordTB.Size.Width, 40);
        }

        private void UserButtonLog_Click(object sender, EventArgs e)
        {
            var logUser = UserTB.Text;
            var passUser = PasswordTB.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user from register_USR where login_user = '{logUser}' and password_user = '{passUser}'";
            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table); // ?

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Успешный вход!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddInfoIntoDB UsrShop = new AddInfoIntoDB();
                this.Hide();
                UsrShop.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Аккаунт не найден!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void AdminButtonLog_Click(object sender, EventArgs e)
        {
            var logAdmin = UserTB.Text;
            var passAdmin = PasswordTB.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user from register_ADM where login_user = '{logAdmin}' and password_user = '{passAdmin}'";
            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Успешный вход!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Admin ADMform = new Admin();
                this.Hide();
                ADMform.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Аккаунт не найден!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void labelEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelEXIT_MouseEnter(object sender, EventArgs e)
        {
            labelEXIT.ForeColor = Color.MediumPurple;
        }

        private void labelEXIT_MouseLeave(object sender, EventArgs e)
        {
            labelEXIT.ForeColor = Color.Black;
        }

        Point lastPoint;
        private void panelDOWN_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelDOWN_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panelTOP_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelTOP_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}

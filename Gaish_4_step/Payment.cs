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
    public partial class Payment : Form
    {
        private Panel slidingPanel;
        private Timer timer;
        private int targetTop;
        private const int animationAmplitude = 180;
        private const int animationSpeed = 8;

        private DateTime animationStartTime;
        private Timer timerPictureBox;

        public Payment()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            slidingPanel = panelAnim1;

            timer = new Timer();
            timer.Interval = 15;
            timer.Tick += timer1_Tick;

            slidingPanel.Top = this.Height;

            targetTop = this.Height - slidingPanel.Height;

            timerPictureBox = new Timer();
            timerPictureBox.Interval = 1000;
            timerPictureBox.Tick += timer2_Tick;
        }

        public void SetLabelValue(string value)
        {
            labelHowMuchPay.Text = value;
        }

        private void buttonToPay_Click(object sender, EventArgs e)
        {
            timer.Start();
            pictureBox1.Visible = true;
            
            animationStartTime = DateTime.Now;
            timerPictureBox.Start();
        }

        private void radioButtonSberBank_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSberBank.Checked)
            {
                buttonToPay.Visible = true;
                groupBox1.Visible = true;
            }
        }

        private void radioButtonTinkoff_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTinkoff.Checked)
            {
                buttonToPay.Visible = true;
                groupBox1.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (slidingPanel.Top > targetTop)
            {
                double sineValue = Math.Sin((slidingPanel.Top - targetTop) * Math.PI / 2 / animationAmplitude);
                slidingPanel.Top -= (int)(animationSpeed * sineValue);
            }
            else
            {
                timer.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if ((DateTime.Now - animationStartTime).TotalMilliseconds >= 7000)
            {
                pictureBox1.Visible = false;
                timerPictureBox.Stop();
            }
        }

        private void labelEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelEXIT_Click_1(object sender, EventArgs e)
        {
            User userform = new User();
            userform.Close();
            this.Close();
        }
    }
}

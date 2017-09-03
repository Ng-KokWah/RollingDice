using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollDice
{
    public partial class RollDice : Form
    {
        private static bool count = false;
        public RollDice()
        {
            InitializeComponent();
        }

        private void dicetwo_Click(object sender, EventArgs e)
        {
            RollDice win = new RollDice();
            win.Show();
        }

        private void start_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.Visible = false;
            button2.Enabled = false;
            button2.Visible = false;
            button3.Enabled = false;
            button3.Visible = false;
            button4.Enabled = false;
            button4.Visible = false;
            button5.Enabled = false;
            button5.Visible = false;
            button6.Enabled = false;
            button6.Visible = false;
            button7.Enabled = false;
            button7.Visible = false;
            Random ran = new Random();
            switch(ran.Next(1, 7))
            {
                case 1:
                    button7.Enabled = true;
                    button7.Visible = true;
                    break;
                case 2:
                    button1.Enabled = true;
                    button1.Visible = true;
                    button6.Enabled = true;
                    button6.Visible = true;
                    break;
                case 3:
                    button1.Enabled = true;
                    button1.Visible = true;
                    button7.Enabled = true;
                    button7.Visible = true;
                    button6.Enabled = true;
                    button6.Visible = true;
                    break;
                case 4:
                    button1.Enabled = true;
                    button1.Visible = true;
                    button2.Enabled = true;
                    button2.Visible = true;
                    button5.Enabled = true;
                    button5.Visible = true;
                    button6.Enabled = true;
                    button6.Visible = true;
                    break;
                case 5:
                    button1.Enabled = true;
                    button1.Visible = true;
                    button2.Enabled = true;
                    button2.Visible = true;
                    button7.Enabled = true;
                    button7.Visible = true;
                    button5.Enabled = true;
                    button5.Visible = true;
                    button6.Enabled = true;
                    button6.Visible = true;
                    break;
                case 6:
                    button1.Enabled = true;
                    button1.Visible = true;
                    button2.Enabled = true;
                    button2.Visible = true;
                    button3.Enabled = true;
                    button3.Visible = true;
                    button4.Enabled = true;
                    button4.Visible = true;
                    button5.Enabled = true;
                    button5.Visible = true;
                    button6.Enabled = true;
                    button6.Visible = true;
                    break;
            }
        }

        private Timer timer;
        public void InitTimer()
        {
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 2000;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Random ran = new Random();
            button1.BackColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            button2.BackColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            button3.BackColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            button4.BackColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            button5.BackColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            button6.BackColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            button7.BackColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
        }

        private void RollDice_Load(object sender, EventArgs e)
        {
            InitTimer();
            button1.Enabled = false;
            button1.Visible = false;
            button2.Enabled = false;
            button2.Visible = false;
            button3.Enabled = false;
            button3.Visible = false;
            button4.Enabled = false;
            button4.Visible = false;
            button5.Enabled = false;
            button5.Visible = false;
            button6.Enabled = false;
            button6.Visible = false;
            button7.Enabled = false;
            button7.Visible = false;
        }


    }
}

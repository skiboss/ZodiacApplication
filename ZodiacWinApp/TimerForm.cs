using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZodiacWinApp
{
    public partial class TimerForm : Form
    {
        public TimerForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTimer.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (buttonStartStop.Text == "Start")
            {
                timer1.Enabled = true;
                buttonStartStop.Text = "Stop";
            }
            else
            {
                timer1.Enabled = false;
                buttonStartStop.Text = "Start";
            }
        }

        private void TimerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ZodiacForm form = new ZodiacForm();
            form.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppAPI;

namespace ZodiacWinApp
{
    public partial class ZodiacForm : Form
    {
        public ZodiacForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimerForm form = new TimerForm();
            form.Show();
            this.Hide();
        }

        private void comboBoxMonth_TextChanged(object sender, EventArgs e)
        {
            string[] oddMonths = { "SEP", "APR", "JUN", "NOV" };
            if (oddMonths.Contains(comboBoxMonth.Text))
            {
                numericUpDownDay.Maximum = 30;
            }
            if (comboBoxMonth.Text == "FEB")
            {
                numericUpDownDay.Maximum = 29;
            }

        }

        private void buttonShowSign_Click(object sender, EventArgs e)
        {
            Zodiac zod = new Zodiac()
            {
                Month = comboBoxMonth.Text,
                Day = Convert.ToInt32(numericUpDownDay.Value)
            };
            labelSign.Text = zod.GetSign();
        }
    }
}

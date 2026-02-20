using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int msces = Convert.ToInt32(msecslbl.Text);
            int sces = Convert.ToInt32(secslbl.Text);
            int mins = Convert.ToInt32(minslbl.Text);
            int hrs = Convert.ToInt32(hrslbl.Text);

            msces = msces + 1;
            msecslbl.Text = msces.ToString();

            if (msces >= 60)
            {
                msces = 0;
                msecslbl.Text = msces.ToString();
                 sces = sces + 1;
                secslbl.Text = sces.ToString();

            } else if(sces >= 60)
            {
                sces = 0;
               secslbl.Text = sces.ToString();
                mins = mins + 1;
                minslbl.Text = mins.ToString();
            }
            else if (mins >= 60)
            {
                mins = 0;
                minslbl.Text = mins.ToString();
                hrs = hrs + 1;
                hrslbl.Text = hrs.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            hrslbl.Text = "00";
            minslbl.Text = "00";
            secslbl.Text = "00";
            msecslbl.Text = "00";
            timer1.Enabled = false;

        }
    }
}

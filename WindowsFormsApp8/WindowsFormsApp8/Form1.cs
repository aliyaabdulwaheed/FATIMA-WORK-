using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
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

        private void button1_Click(object sender, EventArgs e)
        {
            int chem = Convert.ToInt32(chemtxt.Text);
            int bio = Convert.ToInt32(biotxt.Text);
            int phy = Convert.ToInt32(phytxt.Text);
            int eng = Convert.ToInt32(engtxt.Text);


            int obtno = chem + bio + phy + eng; 
            obttxt.Text = obtno.ToString();

            totaltxt.Text = "400";

            float per = obtno * 100 / 400;
            pertxt.Text = per.ToString();

            if (per >= 90)
            {
gradetxt.Text = "A+";


            }
             else if (per >= 80)
            {
                gradetxt.Text = "A";


            }
            else if (per >= 70)
            {
                gradetxt.Text = "B";


            }
            else if (per >= 60)
            {
                gradetxt.Text = "C";


            }
            else
            {
                gradetxt.Text = "F";
            }
        }
    }
}

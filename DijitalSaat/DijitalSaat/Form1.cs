using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DijitalSaat
{
    public partial class D : Form
    {
        

        public D()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timerZaman_Tick(object sender, EventArgs e)
        {
            DateTime zaman = DateTime.Now; // Şimdiki Zaman
            labelZaman.Text = zaman.ToString();
            labelYear.Text = zaman.Year.ToString();
            labelMonth.Text = CultureInfo.GetCultureInfo("en-US").DateTimeFormat.MonthNames[zaman.Month - 1];
            labelDay.Text = CultureInfo.GetCultureInfo("en-US").DateTimeFormat.DayNames[(int)zaman.DayOfWeek];



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelYıl_Click(object sender, EventArgs e)
        {

        }

        private void labelGun_Click(object sender, EventArgs e)
        {

        }
    }
}

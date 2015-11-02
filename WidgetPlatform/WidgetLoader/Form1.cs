using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WidgetLoader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.TimeOfDay.Hours.ToString() + ":"+ DateTime.Now.TimeOfDay.Minutes.ToString();
            label2.Text = DateTime.Now.Date.Year + " - " + DateTime.Now.Date.DayOfWeek.ToString() + " ( " + DateTime.Now.Date.Day + "/" + DateTime.Now.Date.Month.ToString() + ")";

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string[] _tips = new string[]
            {
                "Mass makes gravity that makes time!",
                "t = time!",
                "One minute in pluto is 60 years in earth",
                "Fact: Einstein's relativity theory help researches everyday!"

            };

            Tip.Text = _tips[new Random().Next(0, _tips.Length)];
        }
    }
}

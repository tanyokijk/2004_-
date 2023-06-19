using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2004_годинник
{
    public partial class Form1 : Form
    {

        private static Timer vTimer = new Timer();

        private void ShowTime(object vObj, EventArgs e)
        {

            labelTime.Text = DateTime.Now.ToLongTimeString();
        }
        public Form1()
        {
            InitializeComponent();

            labelTime.Text = DateTime.Now.ToLongTimeString();

            vTimer.Tick += new EventHandler(ShowTime);

            vTimer.Interval = 1000;

            vTimer.Start();
            if (DateTime.Now.Minute == 0 && DateTime.Now.Second == 0)
            {
                MessageBox.Show("Рівно "+ DateTime.Now.Hour+" година!", "Годинник");
            }
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }
    }
}

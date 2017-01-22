using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolTimer
{
    public partial class SchoolTimer : Form
    {
        public SchoolTimer()
        {
            InitializeComponent();

            label_currentTime.Text = DateTime.Now.ToLongTimeString();

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            label_currentTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}

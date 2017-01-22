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

            int min = DateTime.Now.Minute;
            if (min < 45)
                Do_sprint();
            else
                Do_break();
        }

        private void Do_sprint()
        {
            label_break.Text = "15:00";
            label_sprint.Text = string.Format("{0}:{1}"
                                            , DateTime.Now.Minute.ToString("D2")
                                            , DateTime.Now.Second.ToString("D2"));
        }

        private void Do_break()
        {
            label_break.Text = string.Format("{0}:{1}"
                                            , (DateTime.Now.Minute - 45).ToString("D2")
                                            , DateTime.Now.Second.ToString("D2"));
            label_sprint.Text = "45:00";
        }
    }
}

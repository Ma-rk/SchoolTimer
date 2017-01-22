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
    using System.Media;

    public partial class SchoolTimer : Form
    {
        private readonly string m_Fur_Eliss = Application.StartupPath + @"\Fur_Eliss.wav";
        private readonly string m_Maiden_Prayer = Application.StartupPath + @"\Maiden_Prayer.wav";

        private SoundPlayer m_Fur_Eliss_snd;
        private SoundPlayer m_Maiden_Prayer_snd;


        public SchoolTimer()
        {
            InitializeComponent();

            label_currentTime.Text = DateTime.Now.ToLongTimeString();

            m_Fur_Eliss_snd = new SoundPlayer(m_Fur_Eliss);
            m_Maiden_Prayer_snd = new SoundPlayer(m_Maiden_Prayer);

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
            if (CheckWorkingHour())
                if (DateTime.Now.Minute == 0 && DateTime.Now.Second == 0)
                    m_Fur_Eliss_snd.Play();

            label_break.Text = "15:00";

            label_sprint.Text = string.Format("{0}:{1}"
                                            , DateTime.Now.Minute.ToString("D2")
                                            , DateTime.Now.Second.ToString("D2"));
        }

        private void Do_break()
        {
            if (CheckWorkingHour())
                if (DateTime.Now.Minute == 45 && DateTime.Now.Second == 0)
                    m_Maiden_Prayer_snd.Play();

            label_sprint.Text = "45:00";

            label_break.Text = string.Format("{0}:{1}"
                                            , (DateTime.Now.Minute - 45).ToString("D2")
                                            , DateTime.Now.Second.ToString("D2"));
        }

        private bool CheckWorkingHour()
        {
            if (DateTime.Now.Hour <= 8 && 18 <= DateTime.Now.Hour)
                return true;

            return false;
        }
    }
}

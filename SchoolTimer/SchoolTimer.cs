using System;
using System.Windows.Forms;

namespace SchoolTimer
{
    using System.Media;

    public partial class SchoolTimer : Form
    {
        //private readonly string m_Fur_Eliss = Application.StartupPath + @"\Fur_Eliss.wav";
        //private readonly string m_Maiden_Prayer = Application.StartupPath + @"\Maiden_Prayer.wav";

        private SoundPlayer m_Fur_Eliss_snd;
        private SoundPlayer m_Maiden_Prayer_snd;

        private TimeSpan m_tsFrom;
        private TimeSpan m_tsTo;


        public SchoolTimer()
        {
            InitializeComponent();

            InitHourCbx();

            m_tsFrom = new TimeSpan(8, 0, 0);
            m_tsTo = new TimeSpan(19, 0, 0);

            label_currentTime.Text = DateTime.Now.ToLongTimeString();

            m_Fur_Eliss_snd = new SoundPlayer(Properties.Resources.Fur_Eliss);
            m_Maiden_Prayer_snd = new SoundPlayer(Properties.Resources.Maiden_Prayer);

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void InitHourCbx()
        {
            for (int i = 0; i < 25; i++)
            {
                if (i != 0)
                    cbx_hourTo.Items.Add(i.ToString());
                if (i != 24)
                    cbx_hourFrom.Items.Add(i.ToString());
            }
            cbx_hourFrom.SelectedIndex = 9;
            cbx_hourTo.SelectedIndex = 20;

            cbx_hourFrom.SelectedIndexChanged += new EventHandler(cbx_hour_SelectedIndexChanged);
            cbx_hourTo.SelectedIndexChanged += new EventHandler(cbx_hour_SelectedIndexChanged);
        }

        private void cbx_hour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_hourFrom.SelectedIndex > cbx_hourTo.SelectedIndex)
            {
                if ((ComboBox)sender == cbx_hourFrom)
                    cbx_hourTo.SelectedIndex = cbx_hourFrom.SelectedIndex;
                else
                    cbx_hourFrom.SelectedIndex = cbx_hourTo.SelectedIndex;
            }
            m_tsFrom = new TimeSpan(Convert.ToInt32(cbx_hourFrom.SelectedItem), 0, 0);
            m_tsTo = new TimeSpan(Convert.ToInt32(cbx_hourTo.SelectedItem), 0, 0);
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
            if (CheckWorkingHour(DateTime.Now))
                if (DateTime.Now.Minute == 0 && DateTime.Now.Second == 0)
                    m_Fur_Eliss_snd.Play();

            label_break.Text = "15:00";

            label_sprint.Text = string.Format("{0}:{1}"
                                            , DateTime.Now.Minute.ToString("D2")
                                            , DateTime.Now.Second.ToString("D2"));
        }

        private void Do_break()
        {
            if (CheckWorkingHour(DateTime.Now))
                if (DateTime.Now.Minute == 45 && DateTime.Now.Second == 0)
                    m_Maiden_Prayer_snd.Play();

            label_sprint.Text = "45:00";

            label_break.Text = string.Format("{0}:{1}"
                                            , (DateTime.Now.Minute - 45).ToString("D2")
                                            , DateTime.Now.Second.ToString("D2"));
        }

        public bool CheckWorkingHour(DateTime now)
        {

            if (TimeSpan.Compare(now.TimeOfDay, m_tsFrom) == -1)
                return false;
            if (TimeSpan.Compare(m_tsTo, now.TimeOfDay) != 1)
                return false;

            return true;
        }

        private void furElissToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_Fur_Eliss_snd.Play();
        }

        private void maidenPrayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_Maiden_Prayer_snd.Play();
        }
    }
}

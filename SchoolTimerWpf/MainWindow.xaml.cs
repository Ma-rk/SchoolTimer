using System;
using System.Windows;
using System.Windows.Threading;

namespace SchoolTimerWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            label_currentTime.Content = DateTime.Now.ToLongTimeString();

            int min = DateTime.Now.Minute;
            if (min < 45)
                Do_sprint();
            else
                Do_break();
        }
        private void Do_sprint()
        {
            label_break.Content = "15:00";

            label_sprint.Content = string.Format("{0}:{1}"
                                            , DateTime.Now.Minute.ToString("D2")
                                            , DateTime.Now.Second.ToString("D2"));
        }
        private void Do_break()
        {
            label_sprint.Content = "45:00";

            label_break.Content = string.Format("{0}:{1}"
                                            , (DateTime.Now.Minute - 45).ToString("D2")
                                            , DateTime.Now.Second.ToString("D2"));
        }
    }
}

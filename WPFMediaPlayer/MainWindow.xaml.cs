using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFMediaPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Uri address;
        public MainWindow()
        {
            InitializeComponent();
        }

        void mediaPause(Object sender, EventArgs e)
        {
            if (btnPausePlay.Content.ToString() == "Pause")
            {
                myMedia.Pause();
                btnPausePlay.Content = "Play";
            }
            else
            {
                myMedia.Play();
                btnPausePlay.Content = "Pause";
            }
        }

        void mediaMute(Object sender, EventArgs e)
        {

            if (myMedia.Volume == 100)
            {
                myMedia.Volume = 0;
                muteButt.Content = "Listen";
            }
            else
            {
                myMedia.Volume = 100;
                muteButt.Content = "Mute";
            }
        }

        void mediaSkip(Object sender, EventArgs e)
        {
            TimeSpan time = new TimeSpan(0, 0, 0, 10, 0);
            myMedia.Position += time;
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            address = new Uri(txtPath.Text);
            myMedia.Source = address;
            myMedia.Volume = 100;
            myMedia.Play();
        }
    }
}

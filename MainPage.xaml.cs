using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;

namespace SashaScreensaver
{
    public partial class MainPage : PhoneApplicationPage
    {

        PhotoChooserTask photoChooserTask;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Initializung PhotoChooser
            photoChooserTask = new PhotoChooserTask();
            photoChooserTask.Completed += new EventHandler<PhotoResult>(photoChooserTask_Completed);
        }

        private void PhoneApplicationPage_Loaded_1(object sender, RoutedEventArgs e)
        {
            // Working with timer
            DispatcherTimer tmr = new DispatcherTimer();
            tmr.Interval = TimeSpan.FromSeconds(1);
            tmr.Tick += OnTimerTick;
            tmr.Start();
        }

        void OnTimerTick(object sender, EventArgs args)
        {
            // Filling TextBoxes with values (time)
            myTimeBox.Text = DateTime.Now.ToLongTimeString();
            myDateBox.Text = DateTime.Now.ToLongDateString();
        }

        private void myBgButton_Click(object sender, RoutedEventArgs e)
        {
            photoChooserTask.Show();
        }

        void photoChooserTask_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                System.Windows.Media.Imaging.BitmapImage bmp = new System.Windows.Media.Imaging.BitmapImage();
                bmp.SetSource(e.ChosenPhoto);
                var app = Application.Current as App;
                if (app == null)
                    return;

                var imageBrush = new ImageBrush
                {
                    ImageSource = bmp
                };
                app.RootFrame.Background = imageBrush;
                LayoutRoot.Background = new SolidColorBrush();
            }
        }

        private void LayoutRoot_DoubleTap(object sender, GestureEventArgs e)
        {
            settingsCanvas.Visibility = System.Windows.Visibility.Visible;
        }

        private void canvasCloseButton_Click(object sender, RoutedEventArgs e)
        {
            settingsCanvas.Visibility = System.Windows.Visibility.Collapsed;
        }
    }
}
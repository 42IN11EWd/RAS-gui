using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Run_Approach_Statistics
{
	/// <summary>
	/// Interaction logic for MainScreen.xaml
	/// </summary>
	public partial class MainScreen : Window
	{
		public MainScreen()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

        private void Session_Button(object sender, RoutedEventArgs e)
        {
            MeasurementScreen screen = new MeasurementScreen();
            screen.Show();
            this.Close();
        }

        private void Vault_Button(object sender, RoutedEventArgs e)
        {
            VaultSelector screen = new VaultSelector();
            screen.Show();
            this.Close();
        }

        private void Settings_Button(object sender, RoutedEventArgs e)
        {
            SettingsWindow screen = new SettingsWindow();
            screen.Show();
        }

        private void Gymnast_Button(object sender, RoutedEventArgs e)
        {
            GymnastProfileScreen screen = new GymnastProfileScreen ();
            screen.Show();
            this.Close();
        }

        private void Pilot_Button(object sender, RoutedEventArgs e)
        {
            Boolean laserIsEnabled = PilotButton.Content.ToString().Equals("Set Pilot Laser On");
            PilotButton.Content = (laserIsEnabled ? "Set Pilot Laser Off" : "Set Pilot Laser On");
            RedDot.Visibility = (laserIsEnabled ? System.Windows.Visibility.Visible : System.Windows.Visibility.Hidden);
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int seconds = (int)(e.NewValue / 1000.0);
            int miliSeconds = (int)(e.NewValue % 1000);

            String secondText = (seconds < 10 ? "0" : "") + seconds.ToString();
            String miliSecondText = (miliSeconds < 100 ? (miliSeconds < 10 ? "00" : "0") : "") + miliSeconds.ToString(); ;

            Timetext.Text = "00:" + secondText + ":" + miliSecondText + " - 00:24:640";
        }
	}
}
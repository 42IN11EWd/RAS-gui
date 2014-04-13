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
using System.Windows.Shapes;

namespace Run_Approach_Statistics
{
	/// <summary>
	/// Interaction logic for GymnastProfileScreen.xaml
	/// </summary>
	public partial class GymnastProfileScreen : Window
	{
		public GymnastProfileScreen()
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
            GymnastProfileScreen screen = new GymnastProfileScreen();
            screen.Show();
            this.Close();
        }

        private void Main_Button(object sender, RoutedEventArgs e)
        {
            MainScreen screen = new MainScreen();
            screen.Show();
            this.Close();
        }

        private void Login_Button(object sender, RoutedEventArgs e)
        {
            LoginWindow screen = new LoginWindow();
            screen.Show();
        }
	}
}
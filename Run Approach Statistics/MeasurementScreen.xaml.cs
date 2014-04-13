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
	/// Interaction logic for MeasurementScreen.xaml
	/// </summary>
	public partial class MeasurementScreen : Window
	{
		public MeasurementScreen()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

        private void Stop_Button(object sender, RoutedEventArgs e)
        {
            AfterMeasurementScreen screen = new AfterMeasurementScreen();
            screen.Show();
            this.Close();
        }

        private void EnableManualMode(object sender, RoutedEventArgs e)
        {
            ManualMeasurementButton.IsEnabled = true;
            RedBackground.Visibility = System.Windows.Visibility.Hidden;
        }

        private void DisableManualMode(object sender, RoutedEventArgs e)
        {
            ManualMeasurementButton.IsEnabled = false;
            RedBackground.Visibility = System.Windows.Visibility.Visible;
            ManualMeasurementButton.Content = "Start Measurement";
        }

        private void Measurement_Button(object sender, RoutedEventArgs e)
        {
            Boolean manualMode = ManualMeasurementButton.Content.ToString() == "Start Measurement";
            RedBackground.Visibility = (manualMode ? System.Windows.Visibility.Visible : System.Windows.Visibility.Hidden);
            ManualMeasurementButton.Content = (manualMode ? "Stop Measurement" : "Start Measurement");
        }
	}
}
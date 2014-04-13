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
	/// Interaction logic for Login_Window.xaml
	/// </summary>
	public partial class LoginWindow : Window
	{
		public LoginWindow()
		{
			this.InitializeComponent();
		}

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
	}
}
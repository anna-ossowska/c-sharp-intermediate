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

namespace WpfUpcastingDowncasting
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // This method is executed when the user clicks on the button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Downcasting an object to get access to the members of the Button class:

            // Solution 1: var button = (Button)sender;

            // Solution 2: using the 'as' keyword:
            var button = sender as Button;
            if (button != null)
            {
                MessageBox.Show(button.ActualHeight.ToString());
            }
           
            MessageBox.Show("Program is running...");
        }
    }
}

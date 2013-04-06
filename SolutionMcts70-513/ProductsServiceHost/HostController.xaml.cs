using System;
using System.Collections.Generic;
using System.Linq;
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
using System.ServiceModel;
using ProductsServiceLibrary;

namespace ProductsServiceHost
{
    /// <summary>
    /// Interaction logic for HostController.xaml
    /// </summary>
    public partial class HostController :Window
    {
        private ServiceHost productsServiceHost;

        public HostController()
        {
            InitializeComponent();
        }

        private void HandleException(Exception ex)
        {
            MessageBox.Show(ex.Message, "Exception", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Start_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                productsServiceHost = new ServiceHost(typeof(ProductsServiceImpl));
                productsServiceHost.Open();
                Stop.IsEnabled = true;
                Start.IsEnabled = false;
                Status.Text = "Service Running";
            }
            catch(Exception ex)
            {
                HandleException(ex);
            }
        }

        private void Stop_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                productsServiceHost.Close();
                Stop.IsEnabled = true;
                Start.IsEnabled = false;
                Status.Text = "Service Running";
            }
            catch(Exception ex)
            {
                HandleException(ex);
            }           
        }
    }
}

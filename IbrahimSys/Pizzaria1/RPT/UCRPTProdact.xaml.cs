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

namespace Pizzaria1.RPT
{
    /// <summary>
    /// Interaction logic for UCRPTProdact.xaml
    /// </summary>
    public partial class UCRPTProdact : UserControl
    {
        public UCRPTProdact()
        {
            InitializeComponent();
          



        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
            {

                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).GridPrincipalkh.Children.Clear();
                    (window as MainWindow).GridPrincipalkh.Children.Add(new UCShowProdect());
                }
            }
        }
    }
}

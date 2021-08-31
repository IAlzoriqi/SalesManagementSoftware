using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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

namespace Pizzaria1
{
    /// <summary>
    /// Interaction logic for UCAddType.xaml
    /// </summary>
    public partial class UCAddType : UserControl
    {
        public UCAddType()
        {
            InitializeComponent();
        }

        private void btnsavetype_Click(object sender, RoutedEventArgs e)
        {

            string ConString = ConfigurationManager.ConnectionStrings["SalesandInventorySystemDataSet1"].ConnectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConString))
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO type (TYPE )VALUES(@type)";
                    command.Parameters.AddWithValue("@type", txtpxsusername.Text);
                    
            connection.Open();
                    command.ExecuteNonQuery();
                    lblerror.Content = "تم الحفظ";
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

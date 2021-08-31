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
    /// Interação lógica para UserControlEscolha.xam
    /// </summary>
    public partial class UserControlEscolha : UserControl
    {
        public UserControlEscolha()
        {
            InitializeComponent();
       
        }
        private SqlCommand cmd = new SqlCommand();
        private SqlDataReader reader;
        

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {

            MainWindow minw = new MainWindow();


            minw.ListViewMenuRight.IsEnabled = true;
            minw.ListViewMenuRight.IsEnabled = true;
            minw.ListViewMenuRight.IsEnabled = true;
         
            string ConString = ConfigurationManager.ConnectionStrings["SalesandInventorySystemDataSet1"].ConnectionString;
            SqlConnection connection = new SqlConnection(ConString);
            try
            {
         
                using (SqlCommand command = connection.CreateCommand())
                {

                    cmd.CommandText = "Select * from tbluser "
                                + "where USERNAME = '" + txtpxsusername.Text + "' "
                                + "and PASSWORD = '" + txtbxpassowrd.Text + "'";

                    Console.WriteLine(cmd.CommandText);
                    cmd.Connection = connection;
                    connection.Open();
                    reader = cmd.ExecuteReader();

                    int i = 0;

                    while (reader.Read())
                    {
                        i++;
                    }


                    if (i == 1)
                    {

                        MessageBox.Show("تم تسجيل الدخول", "Authentication Failed");
                      
                    }
                    else
                    {
                        MessageBox.Show("INCORRECT PASSWORD OR USER ID", "Authentication Failed");
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Catch Block = " + ex);
            }
            finally
            {


                connection.Close();

            }

        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}

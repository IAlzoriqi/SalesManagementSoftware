using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
    /// Interação lógica para UserControlInicio.xam
    /// </summary>
    public partial class UserControlInicio : UserControl
    {
        public UserControlInicio()
        {
            InitializeComponent();
        }

        private void btnSaveUser_Click(object sender, RoutedEventArgs e)
        {
         
             


                    string ConString = ConfigurationManager.ConnectionStrings["SalesandInventorySystemDataSet1"].ConnectionString;
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(ConString))
                        using (SqlCommand command = connection.CreateCommand())

                        {
                            command.CommandText = "INSERT INTO [dbo].[tbluser]([FIRST_NAME],[LAST_NAME],[USERNAME],[TYPE_ID],[PASSWORD],[LOCATION_ID],[PHONE_NUMBER]) VALUES(@fname,@lname,@uname,@type_id,@pass,@location_id,@phoneNumber)";
                            command.Parameters.AddWithValue("@fname", txtfname.Text);
                            command.Parameters.AddWithValue("@lname", txtlname.Text);
                         
                            command.Parameters.AddWithValue("@uname", txtuname.Text);
                            command.Parameters.AddWithValue("@type_id",cmpotype.SelectedIndex );
                    command.Parameters.AddWithValue("@pass", txtpass.Text);
                    command.Parameters.AddWithValue("@location_id", cmpoLocation.SelectedIndex);
                    command.Parameters.AddWithValue("@phoneNumber", txtphoneNumber.Text);


                    if (connection.State == ConnectionState.Open)
                            {

                                connection.Close();
                                connection.Open();
                            }
                            else
                            {
                                connection.Open();
                            }
                            command.ExecuteNonQuery();
                            lblerror.Content = "تم الحفظ";
                        }
                    }
                    catch (SqlException ex)
                    {
                        lblerror.Content = "err" + ex.ToString();
                MessageBox.Show("err" + ex);
                    }


              
           
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            string ConString = ConfigurationManager.ConnectionStrings["SalesandInventorySystemDataSet1"].ConnectionString;
            string CmdString = string.Empty;
            string CmdString2 = string.Empty;
            using (SqlConnection con = new SqlConnection(ConString))
            {
                try
                {
                    CmdString = "SELECT *  FROM type";
                    SqlCommand cmd = new SqlCommand(CmdString, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("type");
                    sda.Fill(dt);
                    DataRow dr = dt.NewRow();
                    dr["TYPE"] = "اختار نوع المستخدم";
                    dt.Rows.InsertAt(dr, 0);

                    cmpotype.DisplayMemberPath = "TYPE";
                    cmpotype.ItemsSource = dt.DefaultView;
                    //  compySelectCategory.DataContext = dt.DefaultView;

                 

                    CmdString2 = "SELECT *  FROM location";
                    SqlCommand cmd2 = new SqlCommand(CmdString2, con);
                    SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                    DataTable dt2 = new DataTable("location");
                    sda2.Fill(dt2);
                    DataRow dr2 = dt2.NewRow();
                    dr2["PROVINCE"] = "اختار حي المستخدم";
                    dt2.Rows.InsertAt(dr2, 0);

                    cmpoLocation.DisplayMemberPath = "PROVINCE";
                    cmpoLocation.ItemsSource = dt2.DefaultView;

                }catch(Exception ex)
                {
                    MessageBox.Show(ex + "");
                }
            }
        }
    }
}

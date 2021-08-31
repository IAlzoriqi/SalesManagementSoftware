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
    /// Interaction logic for UCAddProdacts.xaml
    /// </summary>
    public partial class UCAddProdacts : UserControl
    {
        public UCAddProdacts()
        {
            InitializeComponent();
        }

        private void btnSaveProdacts_Click(object sender, RoutedEventArgs e)
        {

            if (!string.IsNullOrEmpty(txtquality.Text) || !string.IsNullOrEmpty(txtprice.Text) || !string.IsNullOrEmpty(txtprodctname.Text))
            {


                string ConString = ConfigurationManager.ConnectionStrings["SalesandInventorySystemDataSet1"].ConnectionString;
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConString))
                    using (SqlCommand command = connection.CreateCommand())

                    {
                        command.CommandText = "INSERT INTO [dbo].[product]([NAME],[DESCRIPTION],[QTY_STOCK],[PRICE],[CATEGORY_ID])VALUES(@name,@descr,@qty,@price,@categ_id)";
                        command.Parameters.AddWithValue("@name", txtprodctname.Text);
                        command.Parameters.AddWithValue("@descr", new TextRange(txtDescribprodacts.Document.ContentStart, txtDescribprodacts.Document.ContentEnd).Text);
                        float quality = float.Parse(txtquality.Text);
                        command.Parameters.AddWithValue("@qty", quality);
                        int price = int.Parse(txtprice.Text);
                        command.Parameters.AddWithValue("@price", price);
                        int idcat = compySelectCategory.SelectedIndex;
                        command.Parameters.AddWithValue("@categ_id", idcat);

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
                    lblerror.Content = compySelectCategory.SelectedIndex+ "err" + ex.ToString();
                }

            }
            else
            {
                lblerror.Content = "يرجى ادخال قيمة للمتغير اكوالتي والمتغير";
            }
        }
        private void txtprice_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtprice.Text, "[^0-9]"))
            {
                lblerror.Content = "الرجاء ادخل رقماً";

                txtprice.Text = txtprice.Text.Remove(txtprice.Text.Length - 1);
            }
        }

        private void txtquality_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(txtquality.Text, "[^0-9]"))
            {
                lblerror.Content = "الرجاء ادخل رقماً";
                txtquality.Text = txtquality.Text.Remove(txtquality.Text.Length - 1);
            }

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            string ConString = ConfigurationManager.ConnectionStrings["SalesandInventorySystemDataSet1"].ConnectionString;
            string CmdString = string.Empty;
            using (SqlConnection con = new SqlConnection(ConString))
            {
                CmdString = "SELECT *  FROM category";
                SqlCommand cmd = new SqlCommand(CmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("category");
                sda.Fill(dt);
                DataRow dr = dt.NewRow();
                dr["NAME"] = "Select category NAME";
                dt.Rows.InsertAt(dr, 0);

                compySelectCategory.DisplayMemberPath = "NAME";
                compySelectCategory.ItemsSource = dt.DefaultView;
              //  compySelectCategory.DataContext = dt.DefaultView;
            }
        }
    }
}


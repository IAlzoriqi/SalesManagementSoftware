using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using Microsoft.CSharp;
using Microsoft.Win32;
using Microsoft.SqlServer;
using System.Configuration;
using System.Data.SqlClient;

namespace Pizzaria1
{
    /// <summary>
    /// Interaction logic for UCSetting.xaml
    /// </summary>
    public partial class UCSetting : UserControl
    {
        public UCSetting()
        {
            InitializeComponent();
            // cmbColors.ItemsSource = typeof(Colors).GetProperties();
        }

        

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {

        }
        private void MoveCursorMenu(int index)
        {
            TrainsitionigContentSlide.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, (48 + (60 * index)), 0, 0);
        }

        private void ListViewMenuRight_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            int index = ListViewMenuRight.SelectedIndex;
            MoveCursorMenu(index);

        }
        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            int index = ListViewMenuRight.SelectedIndex;
            MoveCursorMenu(index);

            MainWindow main = new MainWindow();

            switch (index)
            {
                
                case 0:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UCShangeColor());

                    break;
                case 1:
                    DB.ClsDBLinq.backub(lblerr);
                   // lblerr.Content = "تم حفظ نسخة احتيطية";
                    lblerr.Foreground = Brushes.Green;

                    break;
                case 2:
                    Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
                    dlg.Filter = "نسخة احتياطية لقواعد البيانات (.bak)|*.bak"; // Filter files by extension
                    Nullable<bool> result = dlg.ShowDialog();
                    if (result == true)
                    {
                        string ConnectionString = ConfigurationManager.ConnectionStrings["SalesandInventorySystemDataSet1"].ToString();
                        var backupCommand = "BACKUP DATABASE SalesandInventorySystem TO DISK ='"+dlg.FileName+"'";
                        lblerr.Content = dlg.FileName;
                        using (var conn = new SqlConnection(ConnectionString))
                        using (var cmd = new SqlCommand(backupCommand, conn))
                        {
                            conn.Open();
                            
                            cmd.ExecuteNonQuery();
                        }
                    }

                    break;
                case 3:
                    
                    break;
                case 4:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UserControl1());

                    break;

                case 5:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new RPT.UCRPTProdact());

                    break;


                case 6:
                  
                    break;
                case 10:
                   
                    break;

                case 11:
                   
                    break;
                default:
                    break;
            }
}
    }
}

using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Controls.Primitives;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using iText.Layout.Element;
using System.Diagnostics;
using System.Windows.Documents;
using System.Windows.Media.Animation;

namespace Pizzaria1
{
    /// <summary>
    /// Interaction logic for UCShowUser.xaml
    /// </summary>
    public partial class UCShowUser : UserControl
    {

       // DB.DBUser db = new DB.DBUser();

        public object PdfPCell { get; private set; }

        public UCShowUser()
        {
            InitializeComponent();


        }

        private void dataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            

        }


            public void getDATAUSER()
        {

         

string ConString = ConfigurationManager.ConnectionStrings["SalesandInventorySystemDataSet1"].ConnectionString;
            string CmdString = string.Empty;
            using (SqlConnection con = new SqlConnection(ConString))
            {
               
                CmdString = " select tbluser.ID,tbluser.FIRST_NAME,tbluser.LAST_NAME,tbluser.TYPE_ID,type.TYPE,tbluser.PHONE_NUMBER,tbluser.LOCATION_ID,location.CITY,location.STREET,location.PROVINCE from[dbo].[tbluser] , [dbo].[location] , [dbo].[type]where type.TYPE_ID = tbluser.TYPE_ID and tbluser.LOCATION_ID = location.LOCATION_ID ";
                SqlCommand cmd = new SqlCommand(CmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("tbluser");
                sda.Fill(dt);
                dataGrid.ItemsSource = dt.DefaultView;
                //dataGrid.ItemsSource = db.getAllUser().DefaultView;

            }
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
           // ((DataRowView)dataGrid.SelectedItem).Row["PHONE_NUMBER"].ToString();
            this.getDATAUSER();

        }

        private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
          
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                txtid.Text = ((DataRowView)dataGrid.SelectedItem).Row["ID"].ToString();
                txtFIRST_NAME.Text = ((DataRowView)dataGrid.SelectedItem).Row["FIRST_NAME"].ToString();
                txtLOCATION_ID.Text =((DataRowView)dataGrid.SelectedItem).Row["LOCATION_ID"].ToString();
               string formatphone= ((DataRowView)dataGrid.SelectedItem).Row["PHONE_NUMBER"].ToString();
                txtPHoneNO.Text =formatphone;
                txtTYPE.Text = ((DataRowView)dataGrid.SelectedItem).Row["TYPE_ID"].ToString();
                txtLAST_NAME.Text = ((DataRowView)dataGrid.SelectedItem).Row["LAST_NAME"].ToString();
                //  txtFIRST_NAME.Text = ((DataRowView)dataGrid.SelectedItem).Row["FIRST_NAME"].ToString();
            }catch(Exception ex)
            {
              
            }

        }

        private void btninsert_Click(object sender, RoutedEventArgs e)
        {
            string ConString = ConfigurationManager.ConnectionStrings["SalesandInventorySystemDataSet1"].ConnectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConString))
                using (SqlCommand command = connection.CreateCommand())


                {
                    command.CommandText = "INSERT INTO [dbo].[tbluser]([FIRST_NAME],[LAST_NAME],[USERNAME],[TYPE_ID],[PASSWORD],[LOCATION_ID],[PHONE_NUMBER]) VALUES(@fname,@lname,@uname,@type_id,@pass,@location_id,@phoneNumber)";
                    command.Parameters.AddWithValue("@fname", txtFIRST_NAME.Text);
                    command.Parameters.AddWithValue("@lname", txtLAST_NAME.Text);

                    command.Parameters.AddWithValue("@uname", txtusername.Text);
                    command.Parameters.AddWithValue("@type_id", int.Parse(txtTYPE.Text));
                    command.Parameters.AddWithValue("@pass", txtpass.Text);
                    command.Parameters.AddWithValue("@location_id", int.Parse(txtLOCATION_ID.Text));
                    command.Parameters.AddWithValue("@phoneNumber", txtPHoneNO.Text);


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
                    this.getDATAUSER();
                }
            }
            catch (Exception ex)
            {
                lblerror.Content = "err" + ex.ToString();
                MessageBox.Show("err" + ex);
            }




        }
    
    

        private void btnupdate_Click(object sender, RoutedEventArgs e)
        {

             string ConString = ConfigurationManager.ConnectionStrings["SalesandInventorySystemDataSet1"].ConnectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConString))
                using (SqlCommand command = connection.CreateCommand())

                {
                    command.CommandText = "update  [dbo].[tbluser] set [FIRST_NAME]=@fname,[LAST_NAME]=@lname,[TYPE_ID]=@type_id,[LOCATION_ID]=@location_id,[PHONE_NUMBER]=@phoneNumber where ID=@id";
                    command.Parameters.AddWithValue("@id", int.Parse(txtid.Text));
                    command.Parameters.AddWithValue("@fname", txtFIRST_NAME.Text);
                    command.Parameters.AddWithValue("@lname", txtLAST_NAME.Text);

                    command.Parameters.AddWithValue("@type_id", int.Parse(txtTYPE.Text));
                    command.Parameters.AddWithValue("@location_id", int.Parse(txtLOCATION_ID.Text));
                    command.Parameters.AddWithValue("@phoneNumber", txtPHoneNO.Text);


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
                    lblerror.Content = "تم التعديل";
                    this.getDATAUSER();
                }
            }
            catch (Exception )
            {
                lblerror.Content = "لم تتم العملية يرجي مراجعة الخطاء";
            }
        }

        private void btnDelet_Click(object sender, RoutedEventArgs e)
        {
            //


            string ConString = ConfigurationManager.ConnectionStrings["SalesandInventorySystemDataSet1"].ConnectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConString))
                using (SqlCommand command = connection.CreateCommand())

                {
                    command.CommandText = "DELETE FROM [dbo].[tbluser] where ID=@id";
                    command.Parameters.AddWithValue("@id", int.Parse(txtid.Text));


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
                    lblerror.Content = "تم الحذف";
                    this.getDATAUSER();
                }
            }
            catch (SqlException ex)
            {
                lblerror.Content = "err" + ex.ToString();
                
            }
        }

        private void btnsearch_Click(object sender, RoutedEventArgs e)
        {

            //  if (System.Text.RegularExpressions.Regex.IsMatch(txtprice.Text, "[^0-9]"))
            // {
            //     lblerror.Content = "الرجاء ادخل رقماً";

            // txtprice.Text = txtprice.Text.Remove(txtprice.Text.Length - 1);
            //  }

            search();
        }


        void search()
        {
            txtSearch.Background = Brushes.WhiteSmoke;
            string ConString = ConfigurationManager.ConnectionStrings["SalesandInventorySystemDataSet1"].ConnectionString;
            try
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    getDATAUSER();
                    txtSearch.Background = Brushes.WhiteSmoke;
                }

                else if (txtSearch.Text.Length > 3)
                {
                    txtSearch.Background = Brushes.WhiteSmoke;
                    string idsub = txtSearch.Text.Substring(2);
                    if (txtSearch.Text.Substring(0, 3) == "ID=" || txtSearch.Text.Substring(0, 3) == "id=" && System.Text.RegularExpressions.Regex.IsMatch(idsub, "[^0-9]"))
                    {

                        string query = "select  tbluser.ID,tbluser.FIRST_NAME,tbluser.LAST_NAME,tbluser.TYPE_ID,type.TYPE,tbluser.PHONE_NUMBER,tbluser.LOCATION_ID,location.CITY,location.STREET,location.PROVINCE from  [dbo].[tbluser] , [dbo].[location] , [dbo].[type] where  type.TYPE_ID = tbluser.TYPE_ID and tbluser.LOCATION_ID = location.LOCATION_ID and ID like '" + txtSearch.Text.Substring(3) + "%'";

                        using (SqlConnection connection = new SqlConnection(ConString))
                        using (SqlCommand command = connection.CreateCommand())
                        {


                            SqlDataAdapter da = new SqlDataAdapter(query, connection);
                            DataSet ds = new DataSet();
                            da.Fill(ds);
                            dataGrid.DataContext = "";
                            dataGrid.ItemsSource = ds.Tables[0].DefaultView;
                            txtSearch.Background = Brushes.SkyBlue;
                            txtSearch.Foreground = Brushes.Black;
                            //  Color color = new Color();



                        }
                    }


                    else if (txtSearch.Text.Substring(0, 3) == "LN=" || txtSearch.Text.Substring(0, 3) == "ln=")//&& System.Text.RegularExpressions.Regex.IsMatch(txtSearch.Text.Substring(4), "[^0-9]"))
                    {

                        string query = "select  tbluser.ID,tbluser.FIRST_NAME,tbluser.LAST_NAME,tbluser.TYPE_ID,type.TYPE,tbluser.PHONE_NUMBER,tbluser.LOCATION_ID,location.CITY,location.STREET,location.PROVINCE from  [dbo].[tbluser] , [dbo].[location] , [dbo].[type] where  type.TYPE_ID = tbluser.TYPE_ID and tbluser.LOCATION_ID = location.LOCATION_ID and tbluser.LAST_NAME like '" + txtSearch.Text.Substring(3) + "%'";

                        using (SqlConnection connection = new SqlConnection(ConString))
                        using (SqlCommand command = connection.CreateCommand())
                        {


                            SqlDataAdapter da = new SqlDataAdapter(query, connection);
                            DataSet ds = new DataSet();
                            da.Fill(ds);
                            dataGrid.DataContext = da;
                            dataGrid.ItemsSource = ds.Tables[0].DefaultView;
                            txtSearch.Background = Brushes.DarkGreen;

                            // Color color = new Color();



                        }
                    }


                    else if (txtSearch.Text.Substring(0, 3) == "FN=" || txtSearch.Text.Substring(0, 3) == "fn=")//&& System.Text.RegularExpressions.Regex.IsMatch(txtSearch.Text.Substring(4), "[^0-9]"))
                    {
                        txtSearch.Background = Brushes.SkyBlue;
                        txtSearch.Foreground = Brushes.Black;
                        string query = "select  tbluser.ID,tbluser.FIRST_NAME,tbluser.LAST_NAME,tbluser.TYPE_ID,type.TYPE,tbluser.PHONE_NUMBER,tbluser.LOCATION_ID,location.CITY,location.STREET,location.PROVINCE from  [dbo].[tbluser] , [dbo].[location] , [dbo].[type] where  type.TYPE_ID = tbluser.TYPE_ID and tbluser.LOCATION_ID = location.LOCATION_ID and tbluser.FIRST_NAME ='" + txtSearch.Text.Substring(3) + "' or  type.TYPE_ID = tbluser.TYPE_ID and tbluser.LOCATION_ID = location.LOCATION_ID and tbluser.FIRST_NAME like '" + txtSearch.Text.Substring(3) + "%'";

                        using (SqlConnection connection = new SqlConnection(ConString))
                        using (SqlCommand command = connection.CreateCommand())
                        {


                            SqlDataAdapter da = new SqlDataAdapter(query, connection);
                            DataSet ds = new DataSet();
                            da.Fill(ds);
                            dataGrid.DataContext = da;
                            dataGrid.ItemsSource = ds.Tables[0].DefaultView;

                            // Color color = new Color();



                        }
                    }
                    else if (txtSearch.Text.Substring(0, 4) == "tid=" || txtSearch.Text.Substring(0, 4) == "TID=")//&& System.Text.RegularExpressions.Regex.IsMatch(txtSearch.Text.Substring(4), "[^0-9]"))
                    {

                        string query = "select tbluser.ID,tbluser.FIRST_NAME,tbluser.LAST_NAME,tbluser.TYPE_ID,type.TYPE,tbluser.PHONE_NUMBER,tbluser.LOCATION_ID,location.CITY,location.STREET,location.PROVINCE from  [dbo].[tbluser] , [dbo].[location] , [dbo].[type] where  type.TYPE_ID = tbluser.TYPE_ID and tbluser.LOCATION_ID = location.LOCATION_ID and tbluser.TYPE_ID ='" + txtSearch.Text.Substring(4) + "' or  type.TYPE_ID = tbluser.TYPE_ID  and tbluser.LOCATION_ID = location.LOCATION_ID  and tbluser.TYPE_ID like '" + txtSearch.Text.Substring(4) + "%'";

                        using (SqlConnection connection = new SqlConnection(ConString))
                        using (SqlCommand command = connection.CreateCommand())
                        {


                            SqlDataAdapter da = new SqlDataAdapter(query, connection);
                            DataSet ds = new DataSet();
                            da.Fill(ds);
                            dataGrid.DataContext = da;
                            dataGrid.ItemsSource = ds.Tables[0].DefaultView;
                            txtSearch.Background = Brushes.SkyBlue;
                            txtSearch.Foreground = Brushes.Black;

                            // Color color = new Color();



                        }
                    }

                    else if (txtSearch.Text.Substring(0, 3) == "ty=" || txtSearch.Text.Substring(0, 3) == "TY=")//&& System.Text.RegularExpressions.Regex.IsMatch(txtSearch.Text.Substring(4), "[^0-9]"))
                    {

                        string query = "select tbluser.ID,tbluser.FIRST_NAME,tbluser.LAST_NAME,tbluser.TYPE_ID,type.TYPE,tbluser.PHONE_NUMBER,tbluser.LOCATION_ID,location.CITY,location.STREET,location.PROVINCE from  [dbo].[tbluser] , [dbo].[location] , [dbo].[type] where  type.TYPE_ID = tbluser.TYPE_ID and tbluser.LOCATION_ID = location.LOCATION_ID and type.TYPE like '" + txtSearch.Text.Substring(3) + "%'";

                        using (SqlConnection connection = new SqlConnection(ConString))
                        using (SqlCommand command = connection.CreateCommand())
                        {


                            SqlDataAdapter da = new SqlDataAdapter(query, connection);
                            DataSet ds = new DataSet();
                            da.Fill(ds);
                            dataGrid.DataContext = da;
                            dataGrid.ItemsSource = ds.Tables[0].DefaultView;
                            txtSearch.Background = Brushes.SkyBlue;
                            txtSearch.Foreground = Brushes.Black;
                            // Color color = new Color();



                        }
                    }

                    else if (txtSearch.Text.Substring(0, 3) == "ph=" || txtSearch.Text.Substring(0, 3) == "ph=")//&& System.Text.RegularExpressions.Regex.IsMatch(txtSearch.Text.Substring(4), "[^0-9]"))
                    {
                        txtSearch.Background = Brushes.SkyBlue;
                        txtSearch.Foreground = Brushes.Black;
                        string query = "select tbluser.ID,tbluser.FIRST_NAME,tbluser.LAST_NAME,tbluser.TYPE_ID,type.TYPE,tbluser.PHONE_NUMBER,tbluser.LOCATION_ID,location.CITY,location.STREET,location.PROVINCE from  [dbo].[tbluser] , [dbo].[location] , [dbo].[type] where  type.TYPE_ID = tbluser.TYPE_ID and tbluser.LOCATION_ID = location.LOCATION_ID and tbluser.PHONE_NUMBER like '" + txtSearch.Text.Substring(3) + "%'";

                        using (SqlConnection connection = new SqlConnection(ConString))
                        using (SqlCommand command = connection.CreateCommand())
                        {


                            SqlDataAdapter da = new SqlDataAdapter(query, connection);
                            DataSet ds = new DataSet();
                            da.Fill(ds);
                            dataGrid.DataContext = da;
                            dataGrid.ItemsSource = ds.Tables[0].DefaultView;

                            // Color color = new Color();



                        }
                    }
                    else
                    {

                        string query = "select  tbluser.ID,tbluser.FIRST_NAME,tbluser.LAST_NAME,tbluser.TYPE_ID,type.TYPE,tbluser.PHONE_NUMBER,tbluser.LOCATION_ID,location.CITY,location.STREET,location.PROVINCE from  [dbo].[tbluser] , [dbo].[location] , [dbo].[type] where  type.TYPE_ID = tbluser.TYPE_ID and tbluser.LOCATION_ID = location.LOCATION_ID and  LAST_NAME like '" + txtSearch.Text + "%' or FIRST_NAME like '" + txtSearch.Text + "%' or ID like '" + txtSearch.Text + "%' or PHONE_NUMBER like '" + txtSearch.Text + "%'";
                        //txtSearch.Background = Brushes.DarkGreen;
                        using (SqlConnection connection = new SqlConnection(ConString))
                        using (SqlCommand command = connection.CreateCommand())
                        {


                            SqlDataAdapter da = new SqlDataAdapter(query, connection);
                            DataSet ds = new DataSet();
                            da.Fill(ds);
                            dataGrid.DataContext = da;
                            dataGrid.ItemsSource = ds.Tables[0].DefaultView;
                            //  txtSearch.Background = Brushes.DarkGreen;
                        }
                    }

                }



                else
                {


                    string query = "select  tbluser.ID,tbluser.FIRST_NAME,tbluser.LAST_NAME,tbluser.TYPE_ID,type.TYPE,tbluser.PHONE_NUMBER,tbluser.LOCATION_ID,location.CITY,location.STREET,location.PROVINCE from  [dbo].[tbluser] , [dbo].[location] , [dbo].[type] where  type.TYPE_ID = tbluser.TYPE_ID and tbluser.LOCATION_ID = location.LOCATION_ID and  LAST_NAME like '" + txtSearch.Text + "%' or FIRST_NAME like '" + txtSearch.Text + "%' or ID like '" + txtSearch.Text + "%' or PHONE_NUMBER like '" + txtSearch.Text + "%'";

                    using (SqlConnection connection = new SqlConnection(ConString))
                    using (SqlCommand command = connection.CreateCommand())
                    {


                        SqlDataAdapter da = new SqlDataAdapter(query, connection);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dataGrid.DataContext = da;
                        dataGrid.ItemsSource = ds.Tables[0].DefaultView;
                        //   txtSearch.Background = Brushes.DarkGreen;


                    }

                }

            }
            catch (Exception ex)
            {
                lblerror.Content = "err" + ex.ToString();
                MessageBox.Show("err" + ex.ToString());
            }
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

            //   txtSearch.Text = string.Join(Environment.NewLine, "kkkkkkkkk");
            // txtSearch.Text = string.Join(Environment.NewLine, "kkkkkkkkk");
            // txtSearch.Text = string.Join(Environment.NewLine, "kkkkkkkkk");
            // txtSearch.Text = string.Join(Environment.NewLine, "kkkkkkkkk");



            //txtSearch.TextWrapping = TextWrapping.Wrap; (vegetables);

            search();

        }

        private void txtLOCATION_ID_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtLOCATION_ID.Text, "[^0-9]"))
            {
                lblerror.Content = "الرجاء ادخال رقم الموقع";

                txtLOCATION_ID.Text = txtLOCATION_ID.Text.Remove(txtLOCATION_ID.Text.Length - 1);
            }
        }

        private void txtTYPE_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtTYPE.Text, "[^0-9]"))
            {
                lblerror.Content = "الرجاء ادخال رقم صلاحية المستخدم";

                txtTYPE.Text = txtTYPE.Text.Remove(txtTYPE.Text.Length - 1);
            }
        }

        private void txtselection_SelectionChanged(object sender, RoutedEventArgs e)
        {
          

          //  txtSearch.Text = "Selection starts at character #" + txtselection.SelectionStart + Environment.NewLine;
          //  txtSearch.Text += "Selection starts at character # " + txtselection.SelectionStart + Environment.NewLine;
            //txtSearch.Text += "Selected text: '" + txtselection.SelectedText + "'";
        }

        private void btnprintalldataingride_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.PrintDialog Printdlg = new System.Windows.Controls.PrintDialog();
            if ((bool)Printdlg.ShowDialog().GetValueOrDefault())
            {
                Size pageSize = new Size(Printdlg.PrintableAreaWidth, Printdlg.PrintableAreaHeight);
                // sizing of the element.
                dataGrid.Measure(pageSize);
                dataGrid.Arrange(new Rect(5, 5, pageSize.Width, pageSize.Height));
                Printdlg.PrintVisual(dataGrid,"        بيانات المستخخدمين               ");
            }

        }



       
// ... 



 
    
    private void btnexportpdf_Click(object sender, RoutedEventArgs e)
        {
           

            Spire.DataExport.PDF.PDFExport PDFExport = new Spire.DataExport.PDF.PDFExport();

        PDFExport.DataSource = Spire.DataExport.Common.ExportSource.DataTable;

        PDFExport.DataTable = this.dataGrid.DataContext as DataTable;


        PDFExport.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView;
            try
            {
                // PDFExport.SaveToFile("zgzggzgz.pdf");
                //  Process.Start("20110223.pdf");
            }catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
                this.dataGrid.SelectAllCells();
            this.dataGrid.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
            ApplicationCommands.Copy.Execute(null, this.dataGrid);
            this.dataGrid.UnselectAllCells();
            String result = (string)Clipboard.GetData(DataFormats.CommaSeparatedValue);
            try
            {
                StreamWriter sw = new StreamWriter("export.pdf");
                sw.WriteLine(result);
                sw.Close();
                Process.Start("export.pdf");
            }catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void ExportToPdf(DataGrid grid)
        {
            PdfPTable table = new PdfPTable(grid.Columns.Count);
            foreach (DataGridColumn column in grid.Columns)
            {
               // table.AddCell(new Phrase(column.Header));

            }
            table.HeaderRows = 1;
            IEnumerable itemsSource = grid.ItemsSource as IEnumerable;
            if (itemsSource != null)
            {
                foreach (var item in itemsSource)
                {
                    DataGridRow row = grid.ItemContainerGenerator.ContainerFromItem(item) as DataGridRow;
                    if (row != null)
                    {
                        DataGridCellsPresenter presenter = FindVisualChild<DataGridCellsPresenter>(row);
                        for (int i = 0; i < grid.Columns.Count; ++i)
                        {
                            DataGridCell cell = (DataGridCell)presenter.ItemContainerGenerator.ContainerFromIndex(i);
                            TextBlock txt = cell.Content as TextBlock;
                            if (txt != null)
                            {
                                table.AddCell(new Phrase(txt.Text));
                            }
                        }
                    }
                }
              //  pdfcommande.Add(table);

                iText.Layout.Element.Paragraph firstpara = new iText.Layout.Element.Paragraph("Test 1");
           //     pdfcommande.Add(firstpara);
            //    pdfcommande.Close();
            }
        }


        private T FindVisualChild<T>(DependencyObject obj) where T : DependencyObject
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(obj, i);
                if (child != null && child is T)
                    return (T)child;
                else
                {
                    T childOfChild = FindVisualChild<T>(child);
                    if (childOfChild != null)
                        return childOfChild;
                }
            }
            return null;
        }

        private void btnselectprint_Click(object sender, RoutedEventArgs e)
        {


         //   Graphics g = e.Graphics;
            // Draw a label title for the grid  
        //    DrawTopLabel(g);
            // draw the datagrid using the DrawDataGrid method passing the Graphics surface  
         //   bool more = dataGrid.DrawDataGrid(g);
            // if there are more pages, set the flag to cause the form to trigger another print page event  
          //  if (more == true)
          //  {
              //  e.HasMorePages = true;
               // dataGrid.PageNumber++;
         //   }
            PrintDialog printDlg = new PrintDialog();
            // Create a FlowDocument dynamically.  
          
       
            // Create IDocumentPaginatorSource from FlowDocument  
            IDocumentPaginatorSource idpSource =(IDocumentPaginatorSource) dataGrid.DataContext;
            // Call PrintDocument method to send document to printer  
            printDlg.PrintDocument(idpSource.DocumentPaginator, "Hello WPF Printing.");

        }

        private void dataGrid_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}


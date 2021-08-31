using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections;

using System.Data;
using System.Diagnostics;
using System.IO;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;


namespace Pizzaria1
{
    /// <summary>
    /// Interaction logic for UCCateguryControl.xaml
    /// </summary>
    public partial class UCCateguryControl : UserControl
    {
        public UCCateguryControl()
        {
            InitializeComponent();
        }
        private void dataGrid_Loaded(object sender, RoutedEventArgs e)
        {


        }


        public void getDATAUSER()
        {


            /** 
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


                **/

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            // ((DataRowView)dataGrid.SelectedItem).Row["PHONE_NUMBER"].ToString();
            //    this.getDATAUSER();

            showAllCategury();
        }

   

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            try
            {

                DataGridCellInfo defect = dataGrid.SelectedCells[0];

                txtid.Text = ((TextBlock)defect.Column.GetCellContent(defect.Item)).Text;


                DataGridCellInfo defect1 = dataGrid.SelectedCells[1];

                txtFIRST_NAME.Text = ((TextBlock)defect1.Column.GetCellContent(defect.Item)).Text;


                DataGridCellInfo defect2 = dataGrid.SelectedCells[2];

                txtdescrib.Text = ((TextBlock)defect2.Column.GetCellContent(defect.Item)).Text;



              



            }
            catch (Exception )
            { }

           

        }
        public void showAllCategury()
        {
            DB.ClsDBLinq.getAllCategory(dataGrid);
        }

        private void btninsert_Click(object sender, RoutedEventArgs e)
        {


            if (DB.ClsDBLinq.setCategory(txtFIRST_NAME.Text, txtdescrib.Text) == true)
            {
                dataGrid.Items.Clear();
                UserControl_Loaded(sender, e);

                lblerror.Content = "تم الاظافة";

            }
            else
            {
                MessageBox.Show("لم يتم الاضافة");
            }




        }



        private void btnupdate_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("هل تريد تعديل الصنف",
"Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                if (DB.ClsDBLinq.UpdateCateguris(txtid.Text, txtFIRST_NAME.Text, txtdescrib.Text) == true)
                {
                    dataGrid.Items.Clear();
                    UserControl_Loaded(sender, e);
                    lblerror.Content = "تم التعديل";
                }
                else
                {
                    MessageBox.Show("لم يتم التعديل");
                }
                // Close the window  
            }
            else
            {
                // Do not close the window  
            }
           

        }

        private void btnDelet_Click(object sender, RoutedEventArgs e)
        {
            //
            if (MessageBox.Show("هل تريد حذف الصنف",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {

                if (DB.ClsDBLinq.deletCategury(txtid.Text))
                {
                     dataGrid.Items.Clear();
                    UserControl_Loaded(sender, e);
                    lblerror.Content = "تم الحذف";
                }
                else
                {
                    MessageBox.Show("لم يتم الحذف");
                }
            }
            else
            {
                // Do not close the window  
            }


           






        }

        private void btnsearch_Click(object sender, RoutedEventArgs e)
        {

            //  if (System.Text.RegularExpressions.Regex.IsMatch(txtprice.Text, "[^0-9]"))
            // {
            //     lblerror.Content = "الرجاء ادخل رقماً";

            // txtprice.Text = txtprice.Text.Remove(txtprice.Text.Length - 1);
            //  }

            DB.ClsDBLinq.sercheCategury(txtSearch, dataGrid, lblerror);
        }



        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

            //   txtSearch.Text = string.Join(Environment.NewLine, "kkkkkkkkk");
            // txtSearch.Text = string.Join(Environment.NewLine, "kkkkkkkkk");
            // txtSearch.Text = string.Join(Environment.NewLine, "kkkkkkkkk");
            // txtSearch.Text = string.Join(Environment.NewLine, "kkkkkkkkk");



            //txtSearch.TextWrapping = TextWrapping.Wrap; (vegetables);

            DB.ClsDBLinq.sercheCategury(txtSearch, dataGrid, lblerror);

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
                Printdlg.PrintVisual(dataGrid, "        بيانات المستخخدمين               ");
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
            }
            catch (Exception ex)
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
            }
            catch (Exception ex)
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
            IDocumentPaginatorSource idpSource = (IDocumentPaginatorSource)dataGrid.DataContext;
            // Call PrintDocument method to send document to printer  
            printDlg.PrintDocument(idpSource.DocumentPaginator, "Hello WPF Printing.");

        }
       
        private void dataGrid_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }


    }
}
    


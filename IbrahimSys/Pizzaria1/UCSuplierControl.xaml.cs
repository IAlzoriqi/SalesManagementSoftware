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
    /// Interaction logic for UCSuplierControl.xaml
    /// </summary>
    public partial class UCSuplierControl : UserControl
    {
        public UCSuplierControl()
        {
            InitializeComponent();
        }

        private void dataGrid_Loaded(object sender, RoutedEventArgs e)
        {


        }


    

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
           
            showAllSupplier();
        }



        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            try
            {

                DataGridCellInfo defect = dataGrid.SelectedCells[0];

                txtid.Text = ((TextBlock)defect.Column.GetCellContent(defect.Item)).Text;


                DataGridCellInfo defect1 = dataGrid.SelectedCells[1];

                txtnamecombny.Text = ((TextBlock)defect1.Column.GetCellContent(defect.Item)).Text;


                DataGridCellInfo defect2 = dataGrid.SelectedCells[2];

                txtphonNumber.Text = ((TextBlock)defect2.Column.GetCellContent(defect.Item)).Text;


                DataGridCellInfo defect3 = dataGrid.SelectedCells[3];

                txtlocation.Text = ((TextBlock)defect3.Column.GetCellContent(defect.Item)).Text;



                DataGridCellInfo defect4 = dataGrid.SelectedCells[4];

                txtcity.Text = ((TextBlock)defect4.Column.GetCellContent(defect.Item)).Text;

            
                DataGridCellInfo defect5 = dataGrid.SelectedCells[5];

                txtstreet.Text = ((TextBlock)defect5.Column.GetCellContent(defect.Item)).Text;





            }
            catch (Exception)
            { }



        }
        public void showAllSupplier()
        {
            DB.ClsDBLinq.getAllSupplier(dataGrid);
        }

        private void btninsert_Click(object sender, RoutedEventArgs e)
        {


            if (DB.ClsDBLinq.setSupplier(txtnamecombny.Text,txtphonNumber.Text,txtlocation.Text) == true)
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
            if (MessageBox.Show("هل تريد تعديل بيانات الزبون ",
"Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                if (DB.ClsDBLinq.UpdateSupplier(txtid.Text, txtnamecombny.Text, txtphonNumber.Text,txtlocation.Text) == true)
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
            if (MessageBox.Show("هل تريد حذف بيانات الزبون",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {

                if (DB.ClsDBLinq.deletSupplier(txtid.Text))
                {
                    dataGrid.Items.Clear();
                    UserControl_Loaded(sender, e);
                    lblerror.Content = "تم الحذف";
                }
                else
                {
                    lblerror.Content = "لم يتم الحذف";
                }
            }
            else
            {
                lblerror.Content = "لم يتم الحذف";
            }









        }

        private void btnsearch_Click(object sender, RoutedEventArgs e)
        {

            

            DB.ClsDBLinq.serchSuplier(txtSearch, dataGrid, lblerror);
        }



        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {


            DB.ClsDBLinq.serchSuplier(txtSearch, dataGrid, lblerror);

        }





        private void txtselection_SelectionChanged(object sender, RoutedEventArgs e)
        {



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
                Printdlg.PrintVisual(dataGrid, "        بيانات                ");
            }

        }









        private void btnexportpdf_Click(object sender, RoutedEventArgs e)
        {


            Spire.DataExport.PDF.PDFExport PDFExport = new Spire.DataExport.PDF.PDFExport();

            PDFExport.DataSource = Spire.DataExport.Common.ExportSource.DataTable;

            PDFExport.DataTable = this.dataGrid.DataContext as DataTable;


            PDFExport.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView;
          
            
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

                iText.Layout.Element.Paragraph firstpara = new iText.Layout.Element.Paragraph("Test 1");
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


          
            PrintDialog printDlg = new PrintDialog();


            IDocumentPaginatorSource idpSource = (IDocumentPaginatorSource)dataGrid.DataContext;
            printDlg.PrintDocument(idpSource.DocumentPaginator, "Hello WPF Printing.");

        }

        private void dataGrid_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }


    }
}
    


    


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
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls.Primitives;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using iText.Layout.Element;
using System.Diagnostics;


namespace Pizzaria1
{
    /// <summary>
    /// Interaction logic for UCShowProdect.xaml
    /// </summary>
    public partial class UCShowProdect : UserControl
    {
        public UCShowProdect()
        {
            InitializeComponent();

        
        }

        private void dataGrid_Loaded(object sender, RoutedEventArgs e)
        {
           


          //  DB.ClsDBLinq.getSumPRICEProdect(lblSumSalary);

        }



        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            // ((DataRowView)dataGrid.SelectedItem).Row["PHONE_NUMBER"].ToString();
            //    this.getDATAUSER();

            showprodect();



            try
            {
                int sum = 0;
                for (int i = 0; i < dataGrid.Items.Count - 1; i++)
                {

                    if (!String.IsNullOrEmpty((dataGrid.Columns[4].GetCellContent(dataGrid.Items[i]) as TextBlock).Text))
                        sum += (int.Parse((dataGrid.Columns[4].GetCellContent(dataGrid.Items[i]) as TextBlock).Text));
                }
                lblSumSalary.Content = sum;
            }
            catch (Exception ex) { }
        }

        private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            int sum = 0;
            for (int i = 0; i < dataGrid.Items.Count - 1; i++)
            {
                sum += (int.Parse((dataGrid.Columns[4].GetCellContent(dataGrid.Items[i]) as TextBlock).Text));
            }
            lblSumSalary.Content = sum;
           // DB.ClsDBLinq.getSumPRICEProdect(lblSumSalary);

        }
        private void dataGrid_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGrid.Items.Count - 1; i++)
            {
                sum += (int.Parse((dataGrid.Columns[4].GetCellContent(dataGrid.Items[i]) as TextBlock).Text));
            }
            lblSumSalary.Content = sum;
           // DB.ClsDBLinq.getSumPRICEProdect(lblSumSalary);
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


                DataGridCellInfo defect3 = dataGrid.SelectedCells[3];

                txtqty.Text = ((TextBlock)defect3.Column.GetCellContent(defect.Item)).Text;

                DataGridCellInfo defect4 = dataGrid.SelectedCells[4];

                txtprice.Text = ((TextBlock)defect4.Column.GetCellContent(defect.Item)).Text;

                DataGridCellInfo defect5 = dataGrid.SelectedCells[5];

                txtcategid.Text = ((TextBlock)defect5.Column.GetCellContent(defect.Item)).Text;


                int sum = 0;
                for (int i = 0; i < dataGrid.Items.Count - 1; i++)
                {
                    sum += (int.Parse((dataGrid.Columns[4].GetCellContent(dataGrid.Items[i]) as TextBlock).Text));
                }
                lblSumSalary.Content = sum;

            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }

         

        }
        public void showprodect()
        {
            DB.ClsDBLinq.getAllprodects(dataGrid);



       


            
        }

        private void btninsert_Click(object sender, RoutedEventArgs e)
        {
           

            if (DB.ClsDBLinq.setProdect(txtFIRST_NAME.Text,txtdescrib.Text, txtqty.Text, txtprice.Text, txtcategid.Text)==true)
            {
                dataGrid.Items.Clear();
                UserControl_Loaded(sender, e);

                lblerror.Content = "تم الاظافة";



                int sum = 0;
                for (int i = 0; i < dataGrid.Items.Count - 1; i++)
                {
                    sum += (int.Parse((dataGrid.Columns[4].GetCellContent(dataGrid.Items[i]) as TextBlock).Text));
                }
                lblSumSalary.Content = sum;


            }
            else
            {
                MessageBox.Show("لم يتم الاضافة");
            }




        }



        private void btnupdate_Click(object sender, RoutedEventArgs e)
        {

            if(DB.ClsDBLinq.UpdateProdact(txtid.Text,txtFIRST_NAME.Text, txtdescrib.Text, txtqty.Text, txtprice.Text, txtcategid.Text)==true)
            {
                dataGrid.Items.Clear();
                UserControl_Loaded(sender, e);
                lblerror.Content = "تم التعديل";
            }
            else
            {
                MessageBox.Show("لم يتم التعديل");
            }
           
        }

        private void btnDelet_Click(object sender, RoutedEventArgs e)
        {
            //

            if (DB.ClsDBLinq.deletProdect(txtid.Text))
            {
               // dataGrid.Items.Clear();
                UserControl_Loaded(sender, e);
                lblerror.Content = "تم الحذف";

                int sum = 0;
                for (int i = 0; i < dataGrid.Items.Count - 1; i++)
                {
                    sum += (int.Parse((dataGrid.Columns[4].GetCellContent(dataGrid.Items[i]) as TextBlock).Text));
                }
                lblSumSalary.Content = sum;
            }
            else
            {
                MessageBox.Show("لم يتم الحذف");
            }

          
                    
                
            
           
        }

        private void btnsearch_Click(object sender, RoutedEventArgs e)
        {

            //  if (System.Text.RegularExpressions.Regex.IsMatch(txtprice.Text, "[^0-9]"))
            // {
            //     lblerror.Content = "الرجاء ادخل رقماً";

            // txtprice.Text = txtprice.Text.Remove(txtprice.Text.Length - 1);
            //  }

            DB.ClsDBLinq.serchpPoduct(txtSearch, dataGrid, lblerror);



            int sum = 0;
            for (int i = 0; i < dataGrid.Items.Count - 1; i++)
            {
                sum += (int.Parse((dataGrid.Columns[4].GetCellContent(dataGrid.Items[i]) as TextBlock).Text));
            }
            lblSumSalary.Content = sum;
        }


        
        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

            //   txtSearch.Text = string.Join(Environment.NewLine, "kkkkkkkkk");
            // txtSearch.Text = string.Join(Environment.NewLine, "kkkkkkkkk");
            // txtSearch.Text = string.Join(Environment.NewLine, "kkkkkkkkk");
            // txtSearch.Text = string.Join(Environment.NewLine, "kkkkkkkkk");



            //txtSearch.TextWrapping = TextWrapping.Wrap; (vegetables);

            DB.ClsDBLinq.serchpPoduct(txtSearch, dataGrid, lblerror);



            int sum = 0;
            for (int i = 0; i < dataGrid.Items.Count - 1; i++)
            {
                sum += (int.Parse((dataGrid.Columns[4].GetCellContent(dataGrid.Items[i]) as TextBlock).Text));
            }
            lblSumSalary.Content = sum;

        }

        private void txtLOCATION_ID_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtcategid.Text, "[^0-9]"))
            {
                lblerror.Content = "الرجاء ادخال رقم الموقع";

                txtcategid.Text = txtcategid.Text.Remove(txtcategid.Text.Length - 1);
            }
        }

        private void txtTYPE_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtprice.Text, "[^0-9]"))
            {
                lblerror.Content = "الرجاء ادخال رقم صلاحية المستخدم";

                txtprice.Text = txtprice.Text.Remove(txtprice.Text.Length - 1);
            }
        }

        private void txtselection_SelectionChanged(object sender, RoutedEventArgs e)
        {


            //  txtSearch.Text = "Selection starts at character #" + txtselection.SelectionStart + Environment.NewLine;
            //  txtSearch.Text += "Selection starts at character # " + txtselection.SelectionStart + Environment.NewLine;
            //  txtSearch.Text += "Selected text: '" + txtselection.SelectedText + "'";
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
               // DB.ClsDBLinq.getSumPRICEProdect(lblSumSalary);


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



        private int idprodactselection;

        public int setGetIdProdactSelection
        {
           
            get
            {
                return this.idprodactselection;
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
        private static string _path = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
        public static string ContentStart = _path + @"\RPT\RPTPRODUCT.rpt";

        private void btnselectprint_Click(object sender, RoutedEventArgs e)
        {
            RPT.UCRPTProdact ucrpsprodact = new RPT.UCRPTProdact();
            MainWindow main = new MainWindow();






            if ( !string.IsNullOrEmpty(txtid.Text))
            {
                DataGridCellInfo defect = dataGrid.SelectedCells[0];

                idprodactselection = int.Parse(((TextBlock)defect.Column.GetCellContent(defect.Item)).Text);
                txtFIRST_NAME.Text = idprodactselection.ToString();
              //  RPT.RPTProdectSingle myreport = new RPT.RPTProdectSingle();
                var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
               // myreport.SetParameterValue("@id", idprodactselection);
                //myreport.Load(System.IO.Path.Combine(currentDirectory, "../../RPT/RPTProdectSingle.rpt"));
             //   string exeFolder = (System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName)).Substring(0, (System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName)).Length - 3);
                //  myreport.Load(@"../../\RPT\RPTProdectSingle.rpt");
             //   var dataSet = ReportManager.GetInspectionReportDataSet();
           //     ucrpsprodact.crystalReportsViewer1.ViewerCore.ReportSource = myreport;
               

                foreach (Window window in Application.Current.Windows)
                {

                    if (window.GetType() == typeof(MainWindow))
                    {
                        (window as MainWindow).GridPrincipalkh.Children.Clear();
                        (window as MainWindow).GridPrincipalkh.Children.Add(new RPT.UCRPTProdact());
                    }


                }
            }
            else
            {
                labalerr.Content = "الرجاء اختيار قيمة";

            }

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

            // Create a FlowDocument dynamically.  


            // Create IDocumentPaginatorSource from FlowDocument  
            IDocumentPaginatorSource idpSource = (IDocumentPaginatorSource)dataGrid.DataContext;
            // Call PrintDocument method to send document to printer  
          //  printDlg.PrintDocument(idpSource.DocumentPaginator, "Hello WPF Printing.");

        }
        private void txtqntty_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtqty.Text, "[^0-9]"))
            {
                lblerror.Content = "الرجاء السعر قيمة عشرية";

                txtqty.Text = txtqty.Text.Remove(txtqty.Text.Length - 1);
            }
        }
     


    }
}

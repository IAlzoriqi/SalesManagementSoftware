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

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.IO;

using System.Windows.Controls.Primitives;


namespace Pizzaria1
{
    /// <summary>
    /// Interaction logic for UCShowOrder.xaml
    /// </summary>


    
      /// </summary>
        public partial class UCShowOrder : UserControl
    { 
        ForMoveDataBetowenScreen datasuplier;
        
            public UCShowOrder()
            {
                InitializeComponent();


           DB.ClsDBLinq.getMaxidOrder(txtID_ORDER_INVOICE);
                sealectCompoData();
            showAllSuppliers();
            AddToCompoTypeOrder();



            dataGridSuplier.IsEnabled = false;
            dataGrid.IsEnabled = true;

         datasuplier = new ForMoveDataBetowenScreen();

            showprodect();


            dataGridProdact.IsEnabled = false;

        }



        public void showprodect()
        {
            DB.ClsDBLinq.getAllprodects(dataGridProdact);
            
        }


        public void showAllSuppliers()
        {
            DB.ClsDBLinq.getAllSupplier(dataGridSuplier);
        }


        private void dataGridSuplier_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dataGridGEtSuplier();
            dataGridSuplier.IsEnabled = false;
            dataGrid.IsEnabled=true;


    }
         
            

        FRMgetAllSupliers femgetallsuplier = new FRMgetAllSupliers();



        public  void dataGridGEtSuplier()
        {

            try
            {

                DataGridCellInfo defect = dataGridSuplier.SelectedCells[0];

                txtiduser.Text = ((TextBlock)defect.Column.GetCellContent(defect.Item)).Text;


                DataGridCellInfo defect1 = dataGridSuplier.SelectedCells[1];

                   txtnamecombnyuser.Text = ((TextBlock)defect1.Column.GetCellContent(defect.Item)).Text;


                DataGridCellInfo defect2 = dataGridSuplier.SelectedCells[2];

                 txtphonNumberuser.Text = ((TextBlock)defect2.Column.GetCellContent(defect.Item)).Text;


                DataGridCellInfo defect3 = dataGridSuplier.SelectedCells[3];

                  //txtlocationuser.Text = ((TextBlock)defect3.Column.GetCellContent(defect.Item)).Text;



                DataGridCellInfo defect4 = dataGridSuplier.SelectedCells[4];

                      txtcityuser.Text = ((TextBlock)defect4.Column.GetCellContent(defect.Item)).Text;


                DataGridCellInfo defect5 = dataGridSuplier.SelectedCells[5];

                //     txtstreet.Text = ((TextBlock)defect5.Column.GetCellContent(defect.Item)).Text;




               
            }
            catch (Exception)
            { }



        }


        private void sealectCompoData()
            {




                compySelectday.Items.Add("1");
                compySelectday.Items.Add("2");
                compySelectday.Items.Add("3");
                compySelectday.Items.Add("4");
                compySelectday.Items.Add("5");
                compySelectday.Items.Add("6");
                compySelectday.Items.Add("7");
                compySelectday.Items.Add("8");
                compySelectday.Items.Add("9");
                compySelectday.Items.Add("10");
                compySelectday.Items.Add("11");
                compySelectday.Items.Add("12");
                compySelectday.Items.Add("13");
                compySelectday.Items.Add("14");
                compySelectday.Items.Add("15");
                compySelectday.Items.Add("16");
                compySelectday.Items.Add("17");
                compySelectday.Items.Add("18");
                compySelectday.Items.Add("19");
                compySelectday.Items.Add("20");
                compySelectday.Items.Add("21");
                compySelectday.Items.Add("22");
                compySelectday.Items.Add("23");
                compySelectday.Items.Add("24");
                compySelectday.Items.Add("25");
                compySelectday.Items.Add("26");
                compySelectday.Items.Add("27");
                compySelectday.Items.Add("28");
                compySelectday.Items.Add("29");
                compySelectday.Items.Add("30");
                compySelectday.Items.Add("31");


                compySelecyears.Items.Add("1991");
                compySelecyears.Items.Add("1992");
                compySelecyears.Items.Add("1993");
                compySelecyears.Items.Add("1994");
                compySelecyears.Items.Add("1995");
                compySelecyears.Items.Add("1996");
                compySelecyears.Items.Add("1997");
                compySelecyears.Items.Add("1998");
                compySelecyears.Items.Add("1999");
                compySelecyears.Items.Add("2000");
                compySelecyears.Items.Add("2001");
                compySelecyears.Items.Add("2002");
                compySelecyears.Items.Add("2003");
                compySelecyears.Items.Add("2004");
                compySelecyears.Items.Add("2005");
                compySelecyears.Items.Add("2006");
                compySelecyears.Items.Add("2007");
                compySelecyears.Items.Add("2008");
                compySelecyears.Items.Add("2009");
                compySelecyears.Items.Add("2010");
                compySelecyears.Items.Add("2011");
                compySelecyears.Items.Add("2012");
                compySelecyears.Items.Add("2013");
                compySelecyears.Items.Add("2014");
                compySelecyears.Items.Add("2015");
                compySelecyears.Items.Add("2016");
                compySelecyears.Items.Add("2017");
                compySelecyears.Items.Add("2018");
                compySelecyears.Items.Add("2019");
                compySelecyears.Items.Add("2021");
                compySelecyears.Items.Add("2022");
                compySelecyears.Items.Add("2023");
                compySelecyears.Items.Add("2024");
                compySelecyears.Items.Add("2025");
                compySelecyears.Items.Add("2026");
                compySelecyears.Items.Add("2027");
                compySelecyears.Items.Add("2028");
                compySelecyears.Items.Add("2029");
                compySelecyears.Items.Add("2030");




                compySelectmonth.Items.Add("يناير");
                compySelectmonth.Items.Add("فبراير");
                compySelectmonth.Items.Add("مارس");
                compySelectmonth.Items.Add("ابريل");
                compySelectmonth.Items.Add("مايو");
                compySelectmonth.Items.Add("يونيو");
                compySelectmonth.Items.Add("يوليو");
                compySelectmonth.Items.Add("اغسطس");
                compySelectmonth.Items.Add("سبتمبر");
                compySelectmonth.Items.Add("اكتوبر");
                compySelectmonth.Items.Add("نوفمبر");
                compySelectmonth.Items.Add("ديسمبر");








            }



        void    AddToCompoTypeOrder()
        {

            compySelectTypeOrder.Items.Add("اجل");
            compySelectTypeOrder.Items.Add("نقد");
           
        }

            private void compySelectday_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                if (compySelecyears.SelectedIndex != -1 && compySelectmonth.SelectedIndex != -1 && compySelectday.SelectedIndex != -1)

                txtDATE_ORDER_INVOICE.Text = compySelecyears.SelectedItem + "/" + SelectMonrhsForReturnNo() + "/" + compySelectday.SelectedItem;

            }

            private void compySelectmonth_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                if (compySelecyears.SelectedIndex != -1 && compySelectmonth.SelectedIndex != -1 && compySelectday.SelectedIndex != -1)

                    txtDATE_ORDER_INVOICE.Text = compySelecyears.SelectedItem + "/" + SelectMonrhsForReturnNo() + "/" + compySelectday.SelectedItem;
            }

            private void compySelecyears_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                if (compySelecyears.SelectedIndex != -1 && compySelectmonth.SelectedIndex != -1 && compySelectday.SelectedIndex != -1)
                txtDATE_ORDER_INVOICE.Text = compySelecyears.SelectedItem + "/" + SelectMonrhsForReturnNo() + "/" + compySelectday.SelectedItem;

            }

            private string SelectMonrhsForReturnNo()
            {
                string month = "0";

                if (compySelectmonth.SelectedIndex == 0)
                    return "1";
                else if (compySelectmonth.SelectedIndex == 1)
                    return "2";
                else if (compySelectmonth.SelectedIndex == 2)
                    return "3";
                else if (compySelectmonth.SelectedIndex == 3)
                    return "4";
                else if (compySelectmonth.SelectedIndex == 4)
                    return "5";
                else if (compySelectmonth.SelectedIndex == 5)
                    return "6";
                else if (compySelectmonth.SelectedIndex == 6)
                    return "7";

                else if (compySelectmonth.SelectedIndex == 7)
                    return "7";
                else if (compySelectmonth.SelectedIndex == 8)
                    return "8";
                else if (compySelectmonth.SelectedIndex == 9)
                    return "10";
                else if (compySelectmonth.SelectedIndex == 10)
                    return "11";
                else if (compySelectmonth.SelectedIndex == 11)
                    return "12";
                else
                {
                    return month;
                }


            }



            private void dataGrid_Loaded(object sender, RoutedEventArgs e)
            {


            }




            private void UserControl_Loaded(object sender, RoutedEventArgs e)
            {

            showAllOrder();
            }



            private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {

                try
                {

                    DataGridCellInfo defect = dataGrid.SelectedCells[0];

                    txtID_ORDER_INVOICE.Text = ((TextBlock)defect.Column.GetCellContent(defect.Item)).Text;


                    DataGridCellInfo defect1 = dataGrid.SelectedCells[1];

                    txtDESCRIBTUON_ORDER_INVOICE.Text = ((TextBlock)defect1.Column.GetCellContent(defect.Item)).Text;

                    DataGridCellInfo defect3 = dataGrid.SelectedCells[2];

                txtDATE_ORDER_INVOICE.Text = ((TextBlock)defect3.Column.GetCellContent(defect.Item)).Text;

                    DataGridCellInfo defect5 = dataGrid.SelectedCells[5];

                    txtPRICE_ORDERinvoice.Text = ((TextBlock)defect5.Column.GetCellContent(defect.Item)).Text;


                    DataGridCellInfo defect4 = dataGrid.SelectedCells[4];

                    txtQTY_ORDER_INVOICE.Text = ((TextBlock)defect4.Column.GetCellContent(defect.Item)).Text;



                    DataGridCellInfo defect6 = dataGrid.SelectedCells[4];

                    txtTOTAL_AMOUNT_INVOICE.Text = ((TextBlock)defect6.Column.GetCellContent(defect.Item)).Text;


                    DataGridCellInfo defect7 = dataGrid.SelectedCells[5];

                    txtDATE_ORDER_INVOICE.Text = ((TextBlock)defect7.Column.GetCellContent(defect.Item)).Text;



                int sum = 0;
                for (int i = 0; i < dataGrid.Items.Count - 1; i++)
                {
                    sum += (int.Parse((dataGrid.Columns[5].GetCellContent(dataGrid.Items[i]) as TextBlock).Text));
                }
                txtSumTOTAL.Text = sum.ToString();

                int num = dataGrid.Items.Count;
                txtCountItem.Text = num.ToString();


            }
            catch (Exception)
                { }



            }
            public void showAllOrder()
            {

            if(!String.IsNullOrEmpty(txtiduser.Text))
                DB.ClsDBLinq.getAllOrder(dataGrid,txtiduser.Text);
            }

            private void btninsert_Click(object sender, RoutedEventArgs e)
            {


          



            if (DB.ClsDBLinq.setOrder(txtID_ORDER_INVOICE,
                txtDESCRIBTUON_ORDER_INVOICE.Text,
                txtDATE_ORDER_INVOICE.Text,
                txtiduser.Text,
                txtQTY_ORDER_INVOICE.Text,
                txtPRICE_ORDERinvoice.Text,
                compySelectTypeOrder.Text,
                txtID_PRODACT.Text
                ,txtAMOUNT.Text,
                txtTOTAL_AMOUNT_INVOICE.Text,
                txtDISCOUNT.Text) == true)
                {
                    dataGrid.Items.Clear();
                    UserControl_Loaded(sender, e);

                    lblerror.Content = "تم الاظافة";
             
                int sum = 0;
                for (int i = 0; i < dataGrid.Items.Count - 1; i++)
                {
                    sum += (int.Parse((dataGrid.Columns[5].GetCellContent(dataGrid.Items[i]) as TextBlock).Text));
                }
                txtSumTOTAL.Text = sum.ToString();
                showAllOrder();


            }
            else
                {
                    MessageBox.Show("لم يتم الاضافة");
                }

                    



            }



            private void btnupdate_Click(object sender, RoutedEventArgs e)
            {
                if (MessageBox.Show("هل تريد تعديل الفاتورة الزبون ",
    "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    if (DB.ClsDBLinq.UpdateSupplier(txtID_ORDER_INVOICE.Text, txtDESCRIBTUON_ORDER_INVOICE.Text, txtPRICE_ORDERinvoice.Text, txtQTY_ORDER_INVOICE.Text) == true)
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

                    if (DB.ClsDBLinq.deletSupplier(txtID_ORDER_INVOICE.Text))
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

            txtiduser.Text = datasuplier.IDUSer;
            txtcityuser.Text = datasuplier.CitySuplier;
            txtnamecombnyuser.Text = datasuplier.NameSuplier;
            txtphonNumberuser.Text = datasuplier.PhoneNoSuplier;

        }

        private void btninsertSuplier_Click(object sender, RoutedEventArgs e)
        {


            dataGridSuplier.IsEnabled = true;
            dataGrid.IsEnabled = false;


            //this.femgetallsuplier.Show();




            //this.femgetallsuplier.selection(txtiduser, txtnamecombnyuser, txtphonNumberuser, txtcityuser);
            //   this.dataGridGEtSuplier();

            // dataGridGEtSuplier();

        }

        MainWindow mainWindow = new MainWindow();
        private void btninsertNewSuplier_Click(object sender, RoutedEventArgs e)
        {

           

            dataGridProdact.IsEnabled = true;



        }

        private void dataGridProdact_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            try
            {

                DataGridCellInfo defect = dataGridProdact.SelectedCells[0];

                txtID_PRODACT.Text = ((TextBlock)defect.Column.GetCellContent(defect.Item)).Text;


                DataGridCellInfo defect1 = dataGridProdact.SelectedCells[1];

                txtNAMEPRODACT_ORDER_INVOICE.Text = ((TextBlock)defect1.Column.GetCellContent(defect.Item)).Text; ;


                DataGridCellInfo defect2 = dataGridProdact.SelectedCells[2];

                txtDESCRIBTUON_ORDER_INVOICE.Text = ((TextBlock)defect2.Column.GetCellContent(defect.Item)).Text ;


                DataGridCellInfo defect3 = dataGridProdact.SelectedCells[3];


                DataGridCellInfo defect4 = dataGridProdact.SelectedCells[4];







            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

            dataGridProdact.IsEnabled = false;



        }


        private void txtPRICE_ORDERinvoice_TextChanged(object sender, TextChangedEventArgs e)
        {


            if (System.Text.RegularExpressions.Regex.IsMatch(txtPRICE_ORDERinvoice.Text, "[^0-9]"))
            {
                lblerror.Content = "الرجاء ادخل رقماً";

                txtPRICE_ORDERinvoice.Text = txtPRICE_ORDERinvoice.Text.Remove(txtPRICE_ORDERinvoice.Text.Length - 1);
            }

            if ( !String.IsNullOrEmpty( txtPRICE_ORDERinvoice.Text)&& !String.IsNullOrEmpty(txtQTY_ORDER_INVOICE.Text) && txtPRICE_ORDERinvoice.Text.Length < 9 && txtQTY_ORDER_INVOICE.Text.Length < 9)
            {


                int price, quantyty;

                price= int.Parse(txtPRICE_ORDERinvoice.Text);
               quantyty = int.Parse(txtQTY_ORDER_INVOICE.Text);

                int count = price * quantyty;
                txtTOTAL_AMOUNT_INVOICE.Text = count.ToString();


            }

        }

        private void txtQTY_ORDER_INVOICE_TextChanged(object sender, TextChangedEventArgs e)
        {




            if (System.Text.RegularExpressions.Regex.IsMatch(txtQTY_ORDER_INVOICE.Text, "[^0-9]"))
            {
                lblerror.Content = "الرجاء ادخل رقماً";

                txtQTY_ORDER_INVOICE.Text = txtQTY_ORDER_INVOICE.Text.Remove(txtQTY_ORDER_INVOICE.Text.Length - 1);
            }





            int price, quantyty;

            if (!String.IsNullOrEmpty(txtPRICE_ORDERinvoice.Text) && !String.IsNullOrEmpty(txtQTY_ORDER_INVOICE.Text) && txtPRICE_ORDERinvoice.Text.Length < 9 && txtQTY_ORDER_INVOICE.Text.Length < 9)
            {

                



                    price = int.Parse(txtPRICE_ORDERinvoice.Text);
                quantyty = int.Parse(txtQTY_ORDER_INVOICE.Text);

                int count = price * quantyty;
                txtTOTAL_AMOUNT_INVOICE.Text = count.ToString();


            }
            else
            {
                lblerror.Content = "ادخل رقم صحيح او ادخل قيمه لسعر او الكمية";
                txtTOTAL_AMOUNT_INVOICE.Text = "";


            }

        }

        private void compySelectTypeOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {



        }
    }


    }



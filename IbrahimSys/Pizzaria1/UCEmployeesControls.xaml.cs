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
    /// Interaction logic for UCEmployeesControls.xaml
    /// </summary>
    public partial class UCEmployeesControls : UserControl
    {
        public UCEmployeesControls()
        {
            InitializeComponent();
            sealectCompoData();
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


        private string SelectMonrhsForReturnNo()
        {
            string month ="0";

            if (compySelectmonth.SelectedIndex == 0)
                return "1";
            else if (compySelectmonth.SelectedIndex == 1)
                return "2";
            else if (compySelectmonth.SelectedIndex == 2)
                return "3";
            else if(compySelectmonth.SelectedIndex == 3)
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
            else {
                return month;
            }

            
        }


        /// <summary>
        /// Interaction logic for UCShowProdect.xaml
        /// </summary>


        private void dataGrid_Loaded(object sender, RoutedEventArgs e)
        {

            DB.ClsDBLinq.getSumSalaryEmp(lblSomSalary);
        }



        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            // ((DataRowView)dataGrid.SelectedItem).Row["PHONE_NUMBER"].ToString();
            //    this.getDATAUSER();
            DB.ClsDBLinq.getAllEmployee(dataGrid);
           // showemployedect();
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

                txtlastname.Text = ((TextBlock)defect2.Column.GetCellContent(defect.Item)).Text;


                DataGridCellInfo defect3 = dataGrid.SelectedCells[3];

                txtphoneno.Text = ((TextBlock)defect3.Column.GetCellContent(defect.Item)).Text;

                DataGridCellInfo defect4 = dataGrid.SelectedCells[4];

                txtemail.Text = ((TextBlock)defect4.Column.GetCellContent(defect.Item)).Text;

                DataGridCellInfo defect5 = dataGrid.SelectedCells[5];

                txtdate.Text = ((TextBlock)defect5.Column.GetCellContent(defect.Item)).Text;

                DataGridCellInfo defect6 = dataGrid.SelectedCells[6];

                txtjopno.Text = ((TextBlock)defect6.Column.GetCellContent(defect.Item)).Text;

                DataGridCellInfo defect7 = dataGrid.SelectedCells[10];

                txtlocationno.Text = ((TextBlock)defect7.Column.GetCellContent(defect.Item)).Text;

                



            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }



        }

        public void ForegroundLABEL( Color selectedColor)

        {

            List<Label> textBlocksInUserControlA =

                        ChildControlCaller.SelectObjects<Label>(this);
            

            textBlocksInUserControlA.ForEach(s => s.Foreground = new SolidColorBrush(selectedColor));

        }


        public void backgroundbuton(Color selectedColor)

        {

            List<Button> textBlocksInUserControlA =

                        ChildControlCaller.SelectObjects<Button>(this);


            textBlocksInUserControlA.ForEach(s => s.Background = new SolidColorBrush(selectedColor));

        }
        public void showemployedect()
        {
            DB.ClsDBLinq.getAllEmployee(dataGrid);
        }

        private void btninsert_Click(object sender, RoutedEventArgs e)
        {

         
                if (DB.ClsDBLinq.setEmployee(txtFIRST_NAME.Text,
                txtlastname.Text, txtphoneno.Text,
                txtemail.Text, txtjopno.Text,
                txtdate.Text, txtlocationno.Text) == true)
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

            if (MessageBox.Show("هل تريد تعديل بيانات الموظف",
"Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                if (DB.ClsDBLinq.updateEmployee(txtid.Text, txtFIRST_NAME.Text,
                txtlastname.Text, txtphoneno.Text,
                txtemail.Text, txtjopno.Text,
                txtdate.Text, txtlocationno.Text) == true)
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
        }

        private void btnDelet_Click(object sender, RoutedEventArgs e)
        {
            //

            if (DB.ClsDBLinq.deletProdect(txtid.Text))
            {
                // dataGrid.Items.Clear();
                UserControl_Loaded(sender, e);
                lblerror.Content = "تم الحذف";
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
        }



        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

            //   txtSearch.Text = string.Join(Environment.NewLine, "kkkkkkkkk");
            // txtSearch.Text = string.Join(Environment.NewLine, "kkkkkkkkk");
            // txtSearch.Text = string.Join(Environment.NewLine, "kkkkkkkkk");
            // txtSearch.Text = string.Join(Environment.NewLine, "kkkkkkkkk");



            //txtSearch.TextWrapping = TextWrapping.Wrap; (vegetables);

            DB.ClsDBLinq.serchpPoduct(txtSearch, dataGrid, lblerror);

        }

        private void txtLOCATION_ID_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtlocationno.Text, "[^0-9]"))
            {
                lblerror.Content = "الرجاء ادخال رقم الموقع";

                txtlocationno.Text = txtlocationno.Text .Remove(txtlocationno.Text.Length - 1);
            }
        }

        private void txtTYPE_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtjopno.Text, "[^0-9]"))
            {
                lblerror.Content = "الرج ادخل الرقم الوظيفي";

                txtjopno.Text = txtjopno.Text.Remove(txtjopno.Text.Length - 1);
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
            printDlg.PrintDocument(idpSource.DocumentPaginator, "بيانات الموظفين");

        }
        private void txtqntty_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void txtdate_TextChanged(object sender, TextChangedEventArgs e)
        {
           

        }

        private void compySelectday_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (compySelecyears.SelectedIndex != -1 && compySelectmonth.SelectedIndex != -1 && compySelectday.SelectedIndex != -1)

                txtdate.Text = compySelecyears.SelectedItem + "/" + SelectMonrhsForReturnNo() + "/" + compySelectday.SelectedItem;

        }

        private void compySelectmonth_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (compySelecyears.SelectedIndex != -1 && compySelectmonth.SelectedIndex != -1 && compySelectday.SelectedIndex != -1)

                txtdate.Text = compySelecyears.SelectedItem + "/" + SelectMonrhsForReturnNo() + "/" + compySelectday.SelectedItem ;
        }

        private void compySelecyears_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(compySelecyears.SelectedIndex != -1 && compySelectmonth.SelectedIndex != -1 && compySelectday.SelectedIndex != -1)
            txtdate.Text = compySelecyears.SelectedItem + "/" + SelectMonrhsForReturnNo() + "/" + compySelectday.SelectedItem;

        }
    }
}

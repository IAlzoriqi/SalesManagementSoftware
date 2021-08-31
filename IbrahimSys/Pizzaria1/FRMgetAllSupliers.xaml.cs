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
using System.Windows.Shapes;

namespace Pizzaria1
{
    /// <summary>
    /// Interaction logic for FRMgetAllSupliers.xaml
    /// </summary>
    public partial class FRMgetAllSupliers : Window
    {
        public FRMgetAllSupliers()
        {
            InitializeComponent();
            showAllSupplier();
        }


        private void dataGrid_Loaded(object sender, RoutedEventArgs e)
        {


        }


        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            
        }

        public void showAllSupplier()
        {
            DB.ClsDBLinq.getAllSupplier(dataGridSuplier);
        }


        public void selection()
        {



        }




        ForMoveDataBetowenScreen dataSuplier = new ForMoveDataBetowenScreen();

        private void dataGridSuplier_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            try
            {

                DataGridCellInfo defect = dataGridSuplier.SelectedCells[0];

                dataSuplier.IDUSer = ((TextBlock)defect.Column.GetCellContent(defect.Item)).Text;


                DataGridCellInfo defect1 = dataGridSuplier.SelectedCells[1];

                dataSuplier.NameSuplier = ((TextBlock)defect1.Column.GetCellContent(defect.Item)).Text;


                DataGridCellInfo defect2 = dataGridSuplier.SelectedCells[2];

                dataSuplier.PhoneNoSuplier = ((TextBlock)defect2.Column.GetCellContent(defect.Item)).Text;


                DataGridCellInfo defect3 = dataGridSuplier.SelectedCells[3];

                //  txtlocation.Text = ((TextBlock)defect3.Column.GetCellContent(defect.Item)).Text;



                DataGridCellInfo defect4 = dataGridSuplier.SelectedCells[4];

                dataSuplier.CitySuplier = ((TextBlock)defect4.Column.GetCellContent(defect.Item)).Text;


                DataGridCellInfo defect5 = dataGridSuplier.SelectedCells[5];

                //     txtstreet.Text = ((TextBlock)defect5.Column.GetCellContent(defect.Item)).Text;


                this.Hide();


            }
            catch (Exception) { }
        }
    }
}

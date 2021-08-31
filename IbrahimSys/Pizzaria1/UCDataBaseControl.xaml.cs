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
using Microsoft.SqlServer.Management.Sdk;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Server;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Specialized;

namespace Pizzaria1
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {

            InitializeComponent();
         //   att.getDBforAttatchAndDeAttatch(cmpogetdb);
                  
           // MessageBox.Show(myserver.Name);
        }
      //  DB.clsAttachDBAndCoPy att = new DB.clsAttachDBAndCoPy();
       
        public void DetachDatabase()
        {
          
          //  att.DetachDatabase(label_Copy, cmpogetdb);

        }

        private void btnSaveUser_Click(object sender, RoutedEventArgs e)
        {

            DetachDatabase();
            //att.getDBforAttatchAndDeAttatch(cmpogetdb);



        }

     
            private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            //att.getDBforAttatchAndDeAttatch(cmpogetdb);


            // Do not load your data at design time.
            // if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            // {
            // 	//Load your data here and assign the result to the CollectionViewSource.
            // 	System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["Resource Key for CollectionViewSource"];
            // 	myCollectionViewSource.Source = your data
            // }
        }

        public void AtatchDB()
        {
            //att.AtatchDB(label_Copy);
        }

        private void Btnattatchdb_Click(object sender, RoutedEventArgs e)
        {
           // AtatchDB();

         //   att.getDBforAttatchAndDeAttatch(cmpogetdb);
        }

        private void Btncopyhdb_Click(object sender, RoutedEventArgs e)
        {
        //    att.copyDB(label_Copy);
       //     att.getDBforAttatchAndDeAttatch(cmpogetdb);

        }
    }
}

using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Pizzaria1.DB
{

    class clsAttachDBAndCoPy
    {


        String filebath = "SalesandInventorySystem.mdf";
        String filebathlog = "SalesandInventorySystem_log.ldf";
        Server myserver = new
            Server();
        public void DetachDatabase(Label label, ComboBox comboBox)
        {
            myserver.DetachDatabase(comboBox.Text, true);
            label.Content = "done";

        }

        public void getDBforAttatchAndDeAttatch(ComboBox comboBox)
        {
            DatabaseCollection dbcollec = myserver.Databases;
            for (int i = 0; i < dbcollec.Count; i++)
                comboBox.Items.Add(dbcollec[i].Name);

            //    label1.Text = "done";

            //  cmpogetdbatattch.ItemsSource = dbcollec;
        }


        public bool attachStartup()
        {
            bool res = false;
            DatabaseCollection db = myserver.Databases;

            for (int i = 0; i < db.Count; i++)
            {
                if (db[i].Name == "SalesandInventorySystem") return true;
                else
                {
                    StringCollection path = new StringCollection();
                    path.Add("SalesandInventorySystem.mdf");
                    path.Add("SalesandInventorySystem_log.ldf");
                    myserver.AttachDatabase("SalesandInventorySystem", path);

                }
            }

            return res;
        }
        public void AtatchDB(Label label)
        {
            //  Database db = myserver.Databases[@"C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\atatchdb"];

            //label1.Text = filebath;
            // label2.Text = filebathlog;

            StringCollection path = new StringCollection();
            path.Add(System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + @"\" + "SalesandInventorySystem.mdf");
            path.Add(System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + @"\" + "SalesandInventorySystem_log.ldf");
            myserver.AttachDatabase("SalesandInventorySystem", path);

            label.Content = "done";
        }
        public void copyDB(Label label)
        {
            Database db = myserver.Databases["SalesandInventorySystem"];
            db.SetOffline();

            string timeNow = System.DateTime.Now.ToString("yyyy-MM-dd-(hh-mm-ss-tt-fff)");

            File.Copy(db.PrimaryFilePath + @"\SalesandInventorySystem.mdf", @"allCopy\" + timeNow + "SalesandInventorySystem.mdf");
            File.Copy(db.PrimaryFilePath + @"\SalesandInventorySystem_log.ldf", @"allCopy\" + timeNow + "SalesandInventorySystem_log.ldf");
            label.Content = "done";

            File.Copy(db.PrimaryFilePath + @"\SalesandInventorySystem.mdf", @"lastCopy\" + "SalesandInventorySystem.mdf", true);
            File.Copy(db.PrimaryFilePath + @"\SalesandInventorySystem_log.ldf", @"lastCopy\" + "SalesandInventorySystem.ldf", true);
            label.Content = "done";
            db.SetOnline();
        }
    }
}

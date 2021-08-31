using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Pizzaria1.DB
{
    class ClsDBLinq
    {
        static public ClsLinqSqlDataContext db = new ClsLinqSqlDataContext();
        public Int32 ProjectID { get; set; }




     public static void getMaxidOrder(TextBox Textidborder)
        {

            var idorders = (from o in db.orders
                           select o.ORDER_ID);
            if (idorders != null)
            {

                var idorder = (from o in db.orders
                               select o.ORDER_ID).Count();
                Textidborder.Text = idorder.ToString();
            }
            else
            {
                Textidborder.Text = "null";

            }
        }
        public static bool setOrder(TextBox Textidborder,string DescribtionOrder, string dataorder, string CUST_ID,string quant, string price, string type_order,string idprodact,string amount,string total_amount,string discount)
        {
            bool s = false;
            try
            {


                order orders = new order();
                orders.DESCRIBTUON_ORDER= DescribtionOrder;
                int idcos = Convert.ToInt32(CUST_ID);
                

                orders.CUST_ID = idcos;
                orders.DATE_ORDER = System.DateTime.Now;
                var idorder=(from o in db.orders
                            select o.ORDER_ID).Count()+1;
                Textidborder.Text = idorder.ToString();


              

                int idorderint = int.Parse(idorder.ToString());


                order_detail od = new order_detail();

                int prc = int.Parse(price);
                od.PRICE = prc;
                if (type_order == "اجل")
                    od.TYPE_ORDER = false;
                if (type_order == "نقد")
                    od.TYPE_ORDER = true;
                int qty = int.Parse(quant);

                od.QTY = qty;
                od.ID_ORDER = idorderint;
                int idprojectint = Convert.ToInt32(idprodact);
                od.ID_PRODUCT = idprojectint;
                float amountfloat = float.Parse(amount);
                od.AMOUNT = amountfloat;
                float total_amountfloat = float.Parse(total_amount);

                od.TOTAL_AMOUNT = total_amountfloat;


                float discountfloat = float.Parse(discount);
                od.DISCOUNT = discountfloat;

                db.orders.InsertOnSubmit(orders);
               




                db.order_details.InsertOnSubmit(od);
                db.SubmitChanges();

                s = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");

            }
            finally
            {

            }


            return s;
        }



        public static void getAllOrder(DataGrid dg,string idsuplier)
        {

            int idsuplierint = int.Parse(idsuplier);

            var results = (from o in db.orders
                           from d in db.order_details
                           from p in db.products
                           from s in db.suppliers
                           where o.ORDER_ID == d.ID_ORDER && p.PRODUCT_ID == d.ID_PRODUCT && s.SUPPLIER_ID == o.CUST_ID
                           && o.CUST_ID == idsuplierint && o.DATE_ORDER == System.DateTime.Now

                           select new
                           {


                               SUPPLIER_ID = s.SUPPLIER_ID  ,
                               NAME = s.COMPANY_NAME,
                               PRODECTid = p.PRODUCT_ID,
                               DESCRIBTUON_ORDER =o.DESCRIBTUON_ORDER,
                               DATE_ORDER = o.DATE_ORDER,
                               QTY_ORDER = d.QTY,
                               COMPANY_NAME =s.COMPANY_NAME,

                               PHONE_NUMBER = s.PHONE_NUMBER,
                               TOTAL_AMOUNT=d.TOTAL_AMOUNT,
                               AMOUNT_ORDER =d.AMOUNT,
                               DISCOUNT_ORDER = d.DISCOUNT,
                               PRICE_ORDER=p.PRICE

     




                           });
            var resultServices = results.ToList();
            foreach (var l in resultServices)
            {


                dg.Items.Add(l);
            }
        }



        public static void getAllprodects(DataGrid dg)
        {
            
            var results = (from p in db.products
                           from c in db.categories
                           where p.CATEGORY_ID == c.CATEGORY_ID  

                           select new
                           {


                              
                               PRODECTid = p.PRODUCT_ID,
                               NAMEORodect = p.NAME,
                               DESCRIPTIONPRODUCT = p.DESCRIPTION,
                               quantyty = p.QTY_STOCK,
                               PRICE = p.PRICE,
                               CATEGORYID = c.CATEGORY_ID,
                               NAMECATEGURY = c.NAME,
                               DESCRIPTIONCATEGURY = c.NAME,
                           });
            var resultServices = results.ToList();
            foreach (var l in resultServices)
            {
                

                dg.Items.Add(l);
            }
        }



        public static void backub(Label lblerr)

        {
            string ConString = ConfigurationManager.ConnectionStrings["SalesandInventorySystemDataSet1"].ConnectionString;
            DateTime now = DateTime.Now;
            if (!CreateBackup(ConString, "SalesandInventorySystem", "C:\backup\back" + DateTime.Now.ToString("yyyyMMdd_hhmmss")+".bak"))
            {
                lblerr.Foreground = Brushes.Red;

                lblerr.Content = "لم يتم انشاء نسخة احتياطية";
            }
            else{
                lblerr.Foreground = Brushes.Green;
                lblerr.Content = " تم انشاء نسخة احتياطية";

            }
        }

        private static bool CreateBackup(string connectionString, string databaseName, string backupFilePath)
        {
            bool st = false;

            /** string ConnectionString = ConfigurationManager.ConnectionStrings["SalesandInventorySystemDataSet1"].ToString();

             SqlConnection cnn = new SqlConnection(ConnectionString);
             SqlCommand cmd = new SqlCommand("backupdb", cnn);
             cmd.CommandType = CommandType.StoredProcedure;
             cnn.Open();
             cmd.ExecuteNonQuery();
             st = true;

             **/
            string ConnectionString = ConfigurationManager.ConnectionStrings["SalesandInventorySystemDataSet1"].ToString();
            var backupCommand = "BACKUP DATABASE SalesandInventorySystem  TO  DISK =  N'" + System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + @"\BackUpDB\" + " back" + DateTime.Now.ToString("yyyyMMdd_hhmmss")+ ".bak '";
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(backupCommand, conn))
            {
                conn.Open();
             
                cmd.ExecuteNonQuery();
                st = true;
            }
    
            return st;

        }

        public static void getAccountSalaryEmp(Label dg)
        {

          
            dg.Content = (from dr in db.jobs.AsEnumerable()
                          where dr.SALARY != null
                          select dr.SALARY).Sum().ToString();


            // var T = (from t in db.jobs group t by db.jobs into g select g.Sum(t => t.SALARY)).ToList();

            //var itemSums = db.jobs.Aggregate((SALARY: 0, SALARY: 0), (sums, item) => (sums.SALARY + item.SALARY, sums.SALARY + item.Done));



        }



        public static void getSumPRICEProdect(Label LblSumPRICE)
        {


            LblSumPRICE.Content = (from dr in db.products.AsEnumerable()
                          where dr.PRICE != null
                          select dr.PRICE).Sum().ToString();


            // var T = (from t in db.jobs group t by db.jobs into g select g.Sum(t => t.SALARY)).ToList();

            //var itemSums = db.jobs.Aggregate((SALARY: 0, SALARY: 0), (sums, item) => (sums.SALARY + item.SALARY, sums.SALARY + item.Done));



        }


        public static void getSumSalaryEmp(Label dg)
        {
           
            var results = (

                           from c in db.jobs

                           group c by 1 into g



                           select new
                           {


                            sumTotal = g.Sum(x => x.SALARY)
                           


                           });

            dg.Content = (from dr in db.jobs.AsEnumerable()
                          where dr.SALARY != null
                          select dr.SALARY).Sum().ToString();


           // var T = (from t in db.jobs group t by db.jobs into g select g.Sum(t => t.SALARY)).ToList();

            //var itemSums = db.jobs.Aggregate((SALARY: 0, SALARY: 0), (sums, item) => (sums.SALARY + item.SALARY, sums.SALARY + item.Done));

        
         
        }


        public static void getAllEmployee(DataGrid dg)
        {

            var results = (from p in db.employees
                           from c in db.jobs
                           from l in db.locations
                           where p.JOB_ID == c.JOB_ID && p.LOCATION_ID == l.LOCATION_ID

                           select new
                           {



                               p.EMPLOYEE_ID,

                               p.FIRST_NAME,
                               p.LAST_NAME,
                               p.PHONE_NUMBER,
                               p.EMAIL,
                               p.HIRED_DATE,
                               p.JOB_ID,
                               c.JOB_TITLE,
                               c.SALARY,
                               c.Curence_Type,
                               p.LOCATION_ID,
                               l.PROVINCE,
                               l.CITY,
                               l.STREET,
              
                              
                           });
            var resultServices = results.ToList();
            foreach (var l in resultServices)
            {


                dg.Items.Add(l);
            }
        }
        public static void serchpPoduct(TextBox txtSearch ,DataGrid dg,Label lblerror)
        {
            dg.Items.Clear();




          
            txtSearch.Background = Brushes.WhiteSmoke;




            if (txtSearch.Text.Length<1)
            {
                getAllprodects(dg);
                txtSearch.Background = Brushes.WhiteSmoke;
            }

            else if (txtSearch.Text.Length > 3)
            {
                lblerror.Content = txtSearch.Text.Substring(3);

                txtSearch.Background = Brushes.WhiteSmoke;
                string idsub = txtSearch.Text.Substring(2);


                //  string query = "select  tbluser.ID,tbluser.FIRST_NAME,tbluser.LAST_NAME,tbluser.TYPE_ID,type.TYPE,tbluser.PHONE_NUMBER,tbluser.LOCATION_ID,location.CITY,location.STREET,location.PROVINCE from  [dbo].[tbluser] , [dbo].[location] , [dbo].[type] where  type.TYPE_ID = tbluser.TYPE_ID and tbluser.LOCATION_ID = location.LOCATION_ID and ID like '" + txtSearch.Text.Substring(3) + "%'";


                if (txtSearch.Text.Substring(0, 3) == "ID=" || txtSearch.Text.Substring(0, 3) == "id=" && System.Text.RegularExpressions.Regex.IsMatch(idsub, "[^0-9]"))
                {
                    txtSearch.Background = Brushes.SkyBlue;
                    txtSearch.Foreground = Brushes.Black;

                    var results = (from p in db.products
                                   from c in db.categories
                                   where( p.CATEGORY_ID == c.CATEGORY_ID) &&( p.PRODUCT_ID == Convert.ToInt16(txtSearch.Text.Substring(3)))
                                   select new
                                   {



                                       PRODECTid = p.PRODUCT_ID,
                                       NAMEORodect = p.NAME,
                                       DESCRIPTIONPRODUCT = p.DESCRIPTION,
                                       quantyty = p.QTY_STOCK,
                                       PRICE = p.PRICE,
                                       CATEGORYID = c.CATEGORY_ID,
                                       NAMECATEGURY = c.NAME,
                                       DESCRIPTIONCATEGURY = c.NAME,

                                   });
                    var resultServices = results.ToList();

                    dg.Items.Add(resultServices);
                }




                //string query = "select  tbluser.ID,tbluser.FIRST_NAME,tbluser.LAST_NAME,tbluser.TYPE_ID,type.TYPE,tbluser.PHONE_NUMBER,tbluser.LOCATION_ID,location.CITY,location.STREET,location.PROVINCE from  [dbo].[tbluser] , [dbo].[location] , [dbo].[type] where  type.TYPE_ID = tbluser.TYPE_ID and tbluser.LOCATION_ID = location.LOCATION_ID and tbluser.LAST_NAME like '" + txtSearch.Text.Substring(3) + "%'";

                else if (txtSearch.Text.Substring(0, 3) == "nm=" || txtSearch.Text.Substring(0, 3) == "NM=")
                {
                    txtSearch.Background = Brushes.SkyBlue;
                    txtSearch.Foreground = Brushes.Black;
                    var results = (from p in db.products
                                   from c in db.categories
                                   where p.CATEGORY_ID == c.CATEGORY_ID && p.NAME.Contains(txtSearch.Text.Substring(3))
                                   select new
                                   {



                                       PRODECTid = p.PRODUCT_ID,
                                       NAMEORodect = p.NAME,
                                       DESCRIPTIONPRODUCT = p.DESCRIPTION,
                                       quantyty = p.QTY_STOCK,
                                       PRICE = p.PRICE,
                                       CATEGORYID = c.CATEGORY_ID,
                                       NAMECATEGURY = c.NAME,
                                       DESCRIPTIONCATEGURY = c.NAME,

                                   });
                    var resultServices = results.ToList();

                    dg.Items.Add(resultServices);
                }





                else if (txtSearch.Text.Substring(0, 3) == "DS=" || txtSearch.Text.Substring(0, 3) == "ds=")
                {
                    txtSearch.Background = Brushes.SkyBlue;
                    txtSearch.Foreground = Brushes.Black;
                    var results = (from p in db.products
                                   from c in db.categories
                                   where p.CATEGORY_ID == c.CATEGORY_ID && p.DESCRIPTION.Contains(txtSearch.Text.Substring(3))
                                   select new
                                   {



                                       PRODECTid = p.PRODUCT_ID,
                                       NAMEORodect = p.NAME,
                                       DESCRIPTIONPRODUCT = p.DESCRIPTION,
                                       quantyty = p.QTY_STOCK,
                                       PRICE = p.PRICE,
                                       CATEGORYID = c.CATEGORY_ID,
                                       NAMECATEGURY = c.NAME,
                                       DESCRIPTIONCATEGURY = c.NAME,

                                   });
                    var resultServices = results.ToList();

                    dg.Items.Add(resultServices);
                }



                else if (txtSearch.Text.Substring(0, 3) == "QN=" || txtSearch.Text.Substring(0, 3) == "qn=")
                {
                    txtSearch.Background = Brushes.SkyBlue;
                    txtSearch.Foreground = Brushes.Black;
                    var results = (from p in db.products
                                   from c in db.categories
                                   where p.CATEGORY_ID == c.CATEGORY_ID && p.PRICE == Convert.ToInt16(txtSearch.Text.Substring(3))
                                   select new
                                   {



                                       PRODECTid = p.PRODUCT_ID,
                                       NAMEORodect = p.NAME,
                                       DESCRIPTIONPRODUCT = p.DESCRIPTION,
                                       quantyty = p.QTY_STOCK,
                                       PRICE = p.PRICE,
                                       CATEGORYID = c.CATEGORY_ID,
                                       NAMECATEGURY = c.NAME,
                                       DESCRIPTIONCATEGURY = c.NAME,

                                   });
                    var resultServices = results.ToList();


                    dg.Items.Add(resultServices);
                }




                else if (txtSearch.Text.Substring(0, 3) == "PR=" || txtSearch.Text.Substring(0, 3) == "pr=")
                {
                    txtSearch.Background = Brushes.SkyBlue;
                    txtSearch.Foreground = Brushes.Black;
                    var results = (from p in db.products
                                   from c in db.categories
                                   where p.CATEGORY_ID == c.CATEGORY_ID && p.PRICE == Convert.ToDouble(txtSearch.Text.Substring(3))
                                   select new
                                   {



                                       PRODECTid = p.PRODUCT_ID,
                                       NAMEORodect = p.NAME,
                                       DESCRIPTIONPRODUCT = p.DESCRIPTION,
                                       quantyty = p.QTY_STOCK,
                                       PRICE = p.PRICE,
                                       CATEGORYID = c.CATEGORY_ID,
                                       NAMECATEGURY = c.NAME,
                                       DESCRIPTIONCATEGURY = c.NAME,

                                   });
                    var resultServices = results.ToList();



                    dg.Items.Add(resultServices);
                }
                else if (txtSearch.Text.Substring(0, 3) == "CI=" || txtSearch.Text.Substring(0, 3) == "ci=")
                {
                    txtSearch.Background = Brushes.SkyBlue;
                    txtSearch.Foreground = Brushes.Black;


                    var results = (from p in db.products
                                   from c in db.categories
                                   where p.CATEGORY_ID == c.CATEGORY_ID && p.CATEGORY_ID == Convert.ToInt16(txtSearch.Text.Substring(3))
                                   select new
                                   {



                                       PRODECTid = p.PRODUCT_ID,
                                       NAMEORodect = p.NAME,
                                       DESCRIPTIONPRODUCT = p.DESCRIPTION,
                                       quantyty = p.QTY_STOCK,
                                       PRICE = p.PRICE,
                                       CATEGORYID = c.CATEGORY_ID,
                                       NAMECATEGURY = c.NAME,
                                       DESCRIPTIONCATEGURY = c.NAME,

                                   }).Skip(2);
                    var resultServices = results.ToList();

                  


                        dg.Items.Add(resultServices);
                    
                }

                else
                {
                    var results = (from p in db.products
                                   from c in db.categories
                                   where ((p.CATEGORY_ID == c.CATEGORY_ID) && (p.CATEGORY_ID.ToString().Contains(txtSearch.Text)) || (p.PRODUCT_ID.ToString().Contains(txtSearch.Text)) || (p.DESCRIPTION.Contains(txtSearch.Text)) || (c.DESCRIPTION.Contains(txtSearch.Text)) || (p.NAME.Contains(txtSearch.Text)) || (c.NAME.ToString().Contains(txtSearch.Text)) || (p.PRICE.ToString().Contains(txtSearch.Text)) || (p.QTY_STOCK.ToString().Contains(txtSearch.Text)))

                                   select new
                                   {



                                       PRODECTid = p.PRODUCT_ID,
                                       NAMEORodect = p.NAME,
                                       DESCRIPTIONPRODUCT = p.DESCRIPTION,
                                       quantyty = p.QTY_STOCK,
                                       PRICE = p.PRICE,
                                       CATEGORYID = c.CATEGORY_ID,
                                       NAMECATEGURY = c.NAME,
                                       DESCRIPTIONCATEGURY = c.NAME,

                                   });
                    var resultServices = results.ToList();

               
                        dg.Items.Add(resultServices);
                    
                }

            }





            else
            {
                txtSearch.Background = Brushes.WhiteSmoke;
                var results = (from p in db.products
                               from c in db.categories
                               where ((p.CATEGORY_ID == c.CATEGORY_ID) && (p.CATEGORY_ID.ToString().Contains(txtSearch.Text)) || (p.PRODUCT_ID.ToString().Contains(txtSearch.Text))||(p.DESCRIPTION.Contains(txtSearch.Text)) || (c.DESCRIPTION.Contains(txtSearch.Text)) || (p.NAME.Contains(txtSearch.Text)) || (c.NAME.ToString().Contains(txtSearch.Text)) || (p.PRICE.ToString().Contains(txtSearch.Text)) || (p.QTY_STOCK.ToString().Contains(txtSearch.Text)))
                               select new
                               {



                                   PRODECTid = p.PRODUCT_ID,
                                   NAMEORodect = p.NAME,
                                   DESCRIPTIONPRODUCT = p.DESCRIPTION,
                                   quantyty = p.QTY_STOCK,
                                   PRICE = p.PRICE,
                                   CATEGORYID = c.CATEGORY_ID,
                                   NAMECATEGURY = c.NAME,
                                   DESCRIPTIONCATEGURY = c.NAME,

                               });
                var resultServices = results.ToList();

             


                    dg.Items.Add(resultServices);
                
            }


        
            
   
            }



        public static void serchSuplier(TextBox txtSearch, DataGrid dg, Label lblerror)
        {
            dg.Items.Clear();





            txtSearch.Background = Brushes.WhiteSmoke;




            if (txtSearch.Text.Length < 1)
            {getAllSupplier(dg);
                txtSearch.Background = Brushes.WhiteSmoke;}

            else if (txtSearch.Text.Length > 3)
            {
                lblerror.Content = txtSearch.Text.Substring(3);

                txtSearch.Background = Brushes.WhiteSmoke;
                string idsub = txtSearch.Text.Substring(2);


                //  string query = "select  tbluser.ID,tbluser.FIRST_NAME,tbluser.LAST_NAME,tbluser.TYPE_ID,type.TYPE,tbluser.PHONE_NUMBER,tbluser.LOCATION_ID,location.CITY,location.STREET,location.PROVINCE from  [dbo].[tbluser] , [dbo].[location] , [dbo].[type] where  type.TYPE_ID = tbluser.TYPE_ID and tbluser.LOCATION_ID = location.LOCATION_ID and ID like '" + txtSearch.Text.Substring(3) + "%'";


                if (txtSearch.Text.Substring(0, 3) == "ID=" || txtSearch.Text.Substring(0, 3) == "id=" && System.Text.RegularExpressions.Regex.IsMatch(idsub, "[^0-9]"))
                {
                    txtSearch.Background = Brushes.SkyBlue;
                    txtSearch.Foreground = Brushes.Black;

                    var results = (from p in db.suppliers
                                   from c in db.locations
                                   where (p.LOCATION_ID == c.LOCATION_ID) 
                                   && (p.SUPPLIER_ID.ToString().Contains(txtSearch.Text.Substring(3)))
                                   select new
                                   {



                                      p.SUPPLIER_ID,
                                      p.COMPANY_NAME,
                                        p.LOCATION_ID,
                                        p.PHONE_NUMBER,
                                        c.CITY,
                                        c.STREET,
                                        c.PROVINCE,

                                   });
                    var resultService = results.ToList();

                    dg.Items.Add(resultService);
                }




                //string query = "select  tbluser.ID,tbluser.FIRST_NAME,tbluser.LAST_NAME,tbluser.TYPE_ID,type.TYPE,tbluser.PHONE_NUMBER,tbluser.LOCATION_ID,location.CITY,location.STREET,location.PROVINCE from  [dbo].[tbluser] , [dbo].[location] , [dbo].[type] where  type.TYPE_ID = tbluser.TYPE_ID and tbluser.LOCATION_ID = location.LOCATION_ID and tbluser.LAST_NAME like '" + txtSearch.Text.Substring(3) + "%'";

                else if (txtSearch.Text.Substring(0, 3) == "nm=" || txtSearch.Text.Substring(0, 3) == "NM=")
                {
                    txtSearch.Background = Brushes.SkyBlue;
                    txtSearch.Foreground = Brushes.Black;
                    var results = (from p in db.suppliers
                                   from c in db.locations
                                   where (p.LOCATION_ID == c.LOCATION_ID)
                                   && (p.COMPANY_NAME == txtSearch.Text.Substring(3))
                                   select new
                                   {



                                       p.SUPPLIER_ID,
                                       p.COMPANY_NAME,
                                       p.LOCATION_ID,
                                       p.PHONE_NUMBER,
                                       c.CITY,
                                       c.STREET,
                                       c.PROVINCE,

                                   });
                    var resultServices = results.ToList();

                    dg.Items.Add(resultServices);
                }





                else if (txtSearch.Text.Substring(0, 3) == "ph=" || txtSearch.Text.Substring(0, 3) == "PH=")
                {
                    txtSearch.Background = Brushes.SkyBlue;
                    txtSearch.Foreground = Brushes.Black;
                    var results = (from p in db.suppliers
                                   from c in db.locations
                                   where (p.LOCATION_ID == c.LOCATION_ID)
                                   && (p.PHONE_NUMBER == txtSearch.Text.Substring(3))
                                   select new
                                   {



                                       p.SUPPLIER_ID,
                                       p.COMPANY_NAME,
                                       p.LOCATION_ID,
                                       p.PHONE_NUMBER,
                                       c.CITY,
                                       c.STREET,
                                       c.PROVINCE,

                                   });
                    var resultService = results.ToList();

                    dg.Items.Add(resultService);
                }



                else if (txtSearch.Text.Substring(0, 3) == "li=" || txtSearch.Text.Substring(0, 3) == "LI=")
                {
                    txtSearch.Background = Brushes.SkyBlue;
                    txtSearch.Foreground = Brushes.Black;
                    var results = (from p in db.suppliers
                                   from c in db.locations
                                   where (p.LOCATION_ID == c.LOCATION_ID) 
                                   && (p.LOCATION_ID.ToString().Contains(txtSearch.Text.Substring(3)))
                                   select new
                                   {



                                       p.SUPPLIER_ID,
                                       p.COMPANY_NAME,
                                       p.LOCATION_ID,
                                       p.PHONE_NUMBER,
                                       c.CITY,
                                       c.STREET,
                                       c.PROVINCE,

                                   });
                    var resultService = results.ToList();


                    dg.Items.Add(resultService);
                }




                

                else
                {
                    var results = (from p in db.suppliers
                                   from c in db.locations
                                   where (p.LOCATION_ID == c.LOCATION_ID) 
                                   && (p.LOCATION_ID.ToString().Contains(txtSearch.Text))
                                   || (p.SUPPLIER_ID.ToString().Contains(txtSearch.Text))
                                   || (p.COMPANY_NAME.Contains(txtSearch.Text))
                                   || (p.PHONE_NUMBER.Contains(txtSearch.Text))
                                   || (c.CITY.Contains(txtSearch.Text))
                                   || (c.STREET.Contains(txtSearch.Text))
                                   || (c.PROVINCE.Contains(txtSearch.Text))

                                   select new
                                   {   p.SUPPLIER_ID,
                                       p.COMPANY_NAME,
                                       p.LOCATION_ID,
                                       p.PHONE_NUMBER,
                                       c.CITY,
                                       c.STREET,
                                       c.PROVINCE,

                                   });
              
                    var resultServices = results.ToList();
                    foreach(var l in resultServices)

                    dg.Items.Add(l);

                }

            }





            else
            {
                var results = (from p in db.suppliers
                               from c in db.locations
                               where (p.LOCATION_ID == c.LOCATION_ID)
                               && (p.LOCATION_ID.ToString().Contains(txtSearch.Text))
                               || (p.SUPPLIER_ID.ToString().Contains(txtSearch.Text))
                               || (p.COMPANY_NAME.Contains(txtSearch.Text))
                               || (p.PHONE_NUMBER.Contains(txtSearch.Text))
                               || (c.CITY.Contains(txtSearch.Text))
                               || (c.STREET.Contains(txtSearch.Text))
                               || (c.PROVINCE.Contains(txtSearch.Text))

                               select new
                               {
                                   p.SUPPLIER_ID,
                                   p.COMPANY_NAME,
                                   p.LOCATION_ID,
                                   p.PHONE_NUMBER,
                                   c.CITY,
                                   c.STREET,
                                   c.PROVINCE,

                               });

                var resultServices = results.ToList();
               
                    dg.Items.Add(resultServices);


            }





        }


        public static void sercheCategury(TextBox txtSearch, DataGrid dg, Label lblerror)
        {
            dg.Items.Clear();





            txtSearch.Background = Brushes.WhiteSmoke;




            if (txtSearch.Text.Length < 1)
            {
                getAllCategory(dg);
                txtSearch.Background = Brushes.WhiteSmoke;
            }

            else if (txtSearch.Text.Length > 3)
            {
                lblerror.Content = txtSearch.Text.Substring(3);

                txtSearch.Background = Brushes.WhiteSmoke;
                string idsub = txtSearch.Text.Substring(2);


                //  string query = "select  tbluser.ID,tbluser.FIRST_NAME,tbluser.LAST_NAME,tbluser.TYPE_ID,type.TYPE,tbluser.PHONE_NUMBER,tbluser.LOCATION_ID,location.CITY,location.STREET,location.PROVINCE from  [dbo].[tbluser] , [dbo].[location] , [dbo].[type] where  type.TYPE_ID = tbluser.TYPE_ID and tbluser.LOCATION_ID = location.LOCATION_ID and ID like '" + txtSearch.Text.Substring(3) + "%'";


                if (txtSearch.Text.Substring(0, 3) == "ID=" || txtSearch.Text.Substring(0, 3) == "id=" && System.Text.RegularExpressions.Regex.IsMatch(idsub, "[^0-9]"))
                {
                    txtSearch.Background = Brushes.SkyBlue;
                    txtSearch.Foreground = Brushes.Black;

                    var results = (from p in db.categories

                                   where (p.CATEGORY_ID == Convert.ToInt16(txtSearch.Text.Substring(3)))
                                   select p);

                    var resultServices = results.ToList();

                    dg.Items.Add(resultServices);
                }




                //string query = "select  tbluser.ID,tbluser.FIRST_NAME,tbluser.LAST_NAME,tbluser.TYPE_ID,type.TYPE,tbluser.PHONE_NUMBER,tbluser.LOCATION_ID,location.CITY,location.STREET,location.PROVINCE from  [dbo].[tbluser] , [dbo].[location] , [dbo].[type] where  type.TYPE_ID = tbluser.TYPE_ID and tbluser.LOCATION_ID = location.LOCATION_ID and tbluser.LAST_NAME like '" + txtSearch.Text.Substring(3) + "%'";

                else if (txtSearch.Text.Substring(0, 3) == "nm=" || txtSearch.Text.Substring(0, 3) == "NM=")
                {
                    txtSearch.Background = Brushes.SkyBlue;
                    txtSearch.Foreground = Brushes.Black;

                    var results = (from p in db.categories

                                   where (p.NAME.Contains((txtSearch.Text.Substring(3))))
                                   select p);

                    var resultServices = results.ToList();

                    dg.Items.Add(resultServices);

                }





                else if (txtSearch.Text.Substring(0, 3) == "DS=" || txtSearch.Text.Substring(0, 3) == "ds=")
                {
                    txtSearch.Background = Brushes.SkyBlue;
                    txtSearch.Foreground = Brushes.Black;

                    var results = (from p in db.categories

                                   where (p.DESCRIPTION.Contains((txtSearch.Text.Substring(3))))
                                   select p);

                    var resultServices = results.ToList();

                    dg.Items.Add(resultServices);
                }





                else
                {
                    var results = (from p in db.categories

                                   where (p.DESCRIPTION.Contains(txtSearch.Text)) || (p.DESCRIPTION.Contains(txtSearch.Text)) || (p.NAME.Contains(txtSearch.Text)) || (p.NAME.ToString().Contains(txtSearch.Text)) || (p.CATEGORY_ID.ToString().Contains(txtSearch.Text))
                                   select p);
                                  
                    var resultServices = results.ToList();


                    dg.Items.Add(resultServices);

                }

            }





            else
            {
                txtSearch.Background = Brushes.WhiteSmoke;
                var results = (from p in db.categories

                               where (p.DESCRIPTION.Contains(txtSearch.Text)) || (p.DESCRIPTION.Contains(txtSearch.Text)) || (p.NAME.Contains(txtSearch.Text)) || (p.NAME.ToString().Contains(txtSearch.Text)) || (p.CATEGORY_ID.ToString().Contains(txtSearch.Text))
                               select p);

                var resultServices = results.ToList();


                dg.Items.Add(resultServices);
            }





        }
        public static bool deletProdect(string idpro)
        {
            bool r = false;
            int idpr = Convert.ToInt32(idpro);
            var deleteprodects =
            from details in db.products
            where details.PRODUCT_ID == idpr
                select details;

            foreach (var detail in deleteprodects)
            {
                db.products.DeleteOnSubmit(detail);
            }

            try
            {
                db.SubmitChanges();
                r = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // Provide for exceptions.
            }
            return r;
        }




        public static bool deletCategury(string idpro)
        {
            bool r = false;
            int idpr = Convert.ToInt32(idpro);
            var deleteprodects =
            from details in db.categories
            where details.CATEGORY_ID == idpr
            select details;

            foreach (var detail in deleteprodects)
            {
                db.categories.DeleteOnSubmit(detail);
            }

            try
            {
                db.SubmitChanges();
                r = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // Provide for exceptions.
            }
            return r;
        }


        public static bool deletSupplier(string idpro)
        {
            bool r = false;
            int idpr = Convert.ToInt32(idpro);
            var deleteprodects =
            from details in db.suppliers
            where details.SUPPLIER_ID == idpr
            select details;

            foreach (var detail in deleteprodects)
            {
                db.suppliers.DeleteOnSubmit(detail);
            }

            try
            {
                db.SubmitChanges();
                r = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // Provide for exceptions.
            }
            return r;
        }
        public static bool UpdateProdact(string idpro,string name ,string Describ, string QTY_Stok, string price ,string catagury_id)
        {
            bool r = false;
       
                             
         

                int idpr = Convert.ToInt32(idpro);

                var query =
                            from prd in db.products
                            where prd.PRODUCT_ID  == idpr
                                select prd;

                foreach (product prod in query)
                {

                    int catg = Convert.ToInt32(catagury_id);


                    if (prod.PRODUCT_ID == idpr)

                    prod.NAME = name;
                    prod.DESCRIPTION = Describ;


                    int qty = int.Parse(QTY_Stok);
                    prod.QTY_STOCK = qty;

                    float pr = float.Parse(price);
                    prod.PRICE = pr;

                    prod.CATEGORY_ID = catg;
                    
                   

                    // Insert any additional changes to column values.
                }
            try
            {


                db.SubmitChanges();
                r = true;


            }
            catch(Exception ex)
            {
                r = false;
                MessageBox.Show(ex.Message);

            }

            return r;
        }

        public static bool UpdateCateguris(string idpro, string name, string Describ)
        {
            bool r = false;




            int idpr = Convert.ToInt32(idpro);

            var query =
                        from prd in db.categories
                        where prd.CATEGORY_ID == idpr
                        select prd;

            foreach (category prod in query)
            {

               


                if (prod.CATEGORY_ID == idpr)

                    prod.NAME = name;
                prod.DESCRIPTION = Describ;


               // int qty = int.Parse(QTY_Stok);
                prod.NAME = name;

                //float pr = float.Parse(price);
                prod.DESCRIPTION = Describ;

               // prod.CATEGORY_ID = catg;



                // Insert any additional changes to column values.
            }
            try
            {


                db.SubmitChanges();
                r = true;


            }
            catch (Exception ex)
            {
                r = false;
                MessageBox.Show(ex.Message);

            }

            return r;
        }

        public static bool updateEmployee(string id,string fname, string lname, string phone, string email, string jopid, string HiredDate, string location)
        {

            bool r = false;




            int idpr = Convert.ToInt32(id);

            var query =
                        from prd in db.employees
                        where prd.EMPLOYEE_ID == idpr
                        select prd;

            foreach (employee prod in query)
            {




                if (prod.EMPLOYEE_ID == idpr)
                   
                prod.FIRST_NAME = fname;
                prod.LAST_NAME = lname;
                prod.PHONE_NUMBER = phone;
                prod.EMAIL = email;
                DateTime hd = Convert.ToDateTime(HiredDate);
                prod.HIRED_DATE = hd;


                int idloc = Convert.ToInt32(location);
                prod.LOCATION_ID = idloc;

                int idjop = Convert.ToInt32(jopid);
                prod.JOB_ID = idjop;
            }
            try
            {


                db.SubmitChanges();
                r = true;


            }
            catch (Exception ex)
            {
                r = false;
                MessageBox.Show(ex.Message);

            }

            return r;
        }
        public static bool UpdateSupplier(string idpro, string name,string phone ,string location)
        {
            bool r = false;




            int idpr = Convert.ToInt32(idpro);

            var query =
                        from prd in db.suppliers
                        where prd.SUPPLIER_ID == idpr
                        select prd;

            foreach (supplier prod in query)
            {




                if (prod.SUPPLIER_ID == idpr)

                    prod.COMPANY_NAME = name;
                prod.LOCATION_ID = Convert.ToInt32( location);


                
                prod.PHONE_NUMBER = phone;

                //float pr = float.Parse(price);
              
                // prod.CATEGORY_ID = catg;



                // Insert any additional changes to column values.
            }
            try
            {


                db.SubmitChanges();
                r = true;


            }
            catch (Exception ex)
            {
                r = false;
                MessageBox.Show(ex.Message);

            }

            return r;
        }


        public static bool setProdect(string name,string Describ ,string QTY_Stok,string price , string catagury_id)
        {
            bool s = false;
            try
            {

       
                    product prod = new product();
                prod.NAME = name;
                    int catg = Convert.ToInt32(catagury_id);
                    prod.CATEGORY_ID = catg;
                    prod.DESCRIPTION = Describ;

                    int qty = int.Parse(QTY_Stok);

                    prod.QTY_STOCK = qty;
                    float pr = float.Parse(price);

                    prod.PRICE = pr;


                    db.products.InsertOnSubmit(prod);
                    db.SubmitChanges();
               
                s = true;
            }
            catch (Exception)
            {
                
            }
            finally
            {

            }

            
            return s;
        }

        public static bool setCategory(string name, string Describ )
        {
            bool s = false;
            try
            {


                category prod = new category();
                prod.NAME = name;
         
                
                prod.DESCRIPTION = Describ;



                prod.NAME = name;
                
               
                db.categories.InsertOnSubmit(prod);
                db.SubmitChanges();

                s = true;
            }
            catch (Exception)
            {
               
            }
            finally
            {

            }


            return s;
        }

        public static bool setSupplier(string name,string phone,string location)
        {
            bool s = false;
            try
            {


                supplier prod = new supplier();
                prod.COMPANY_NAME = name;


                prod.PHONE_NUMBER = phone;


               int idloc = Convert.ToInt32(location);
                prod.LOCATION_ID = idloc;


                db.suppliers.InsertOnSubmit(prod);
                db.SubmitChanges();

                s = true;
            }
            catch (Exception)
            {

            }
            finally
            {

            }


            return s;
        }

        

        public static bool setEmployee(string fname, string lname, string phone, string email, string jopid, string HiredDate, string location)
        {
            bool s = false;
            try
            {


                employee prod = new employee();
                prod.FIRST_NAME = fname;
                prod.LAST_NAME = lname;
                prod.PHONE_NUMBER = phone;

                prod.EMAIL = email;

                DateTime hd= Convert.ToDateTime(HiredDate);
                prod.HIRED_DATE = hd;


                int idloc = Convert.ToInt32(location);
                prod.LOCATION_ID = idloc;

                int idjop = Convert.ToInt32(jopid);
                prod.JOB_ID = idjop;



                db.employees.InsertOnSubmit(prod);
                db.SubmitChanges();

                s = true;
            }
            catch (Exception)
            {

            }
            finally
            {

            }


            return s;
        }





        public static void getAllCustomer(DataGrid dg)
        {
            var tb = from x in db.customers
                     select x;
            dg.ItemsSource = tb;

        }

        public static void getAllCategory(DataGrid dg)
        {
            var tb = from x in db.categories
                     select x;
           // dg.ItemsSource = tb;
            var resultServices = tb.ToList();
            foreach (var l in resultServices)
            {


                dg.Items.Add(l);
            }

        }





        public static void getAlljop(DataGrid dg)
        {
            var tb = from x in db.jobs
                     select x;
            dg.ItemsSource = tb;

        }


        public static void getAllLocation(DataGrid dg)
        {
            var tb = from x in db.locations
                     select x;
            dg.ItemsSource = tb;

        }

        public static void getAllManagers(DataGrid dg)
        {
            var tb = from x in db.managers
                     select x;
            dg.ItemsSource = tb;

        }


        public static void getAllType(DataGrid dg)
        {
            var tb = from x in db.types
                     select x;
            dg.ItemsSource = tb;

        }


        public static void getAllUser(DataGrid dg)
        {
            var tb = from x in db.tblusers
                     select x;
            dg.ItemsSource = tb;

        }

        public static void getAllSupplier(DataGrid dg)
        {
            var results = (from p in db.suppliers
                          from c in db.locations
                          where (p.LOCATION_ID == c.LOCATION_ID)
                          select new
                          {
                              p.SUPPLIER_ID,
                              p.COMPANY_NAME,
                              p.LOCATION_ID,
                              p.PHONE_NUMBER,
                              c.CITY,
                              c.STREET,
                              c.PROVINCE,

                          });
            var resultServices = results.ToList();
            foreach (var l in results)
            {


                dg.Items.Add(l);
            }


        }



    }


}
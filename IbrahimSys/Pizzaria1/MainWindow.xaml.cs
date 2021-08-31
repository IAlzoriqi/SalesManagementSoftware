
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Text;

using System.Windows;
using System.Windows.Controls;

using System.Windows.Input;
using System.Windows.Media;



namespace Pizzaria1
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        //  Accord.Video.FFMPEG.VideoFileWriter vf;
        public static MainWindow Me;
      //  DB.clsAttachDBAndCoPy att;

        public MainWindow()
        {
            Me = this;
         //   File.Copy(System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) 
          //      + @"\program\Pizzaria1.exe", System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + @"\Pizzaria1.exe",true);

            InitializeComponent();
            this.ListViewMenuRight.IsEnabled = true;
          // att = new DB.clsAttachDBAndCoPy();
          //  att.attachStartup();
            //  ExecuteServer();
            // ExecuteClient();
        }
       



        private void attachDB()
        {
        //  SalesandInventorySystemDataSet db=MyserV 
        }


        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
              //  DragMove();
            } catch (Exception  ex)
            {

                lblerror.Content = " error " + ex;
            }
            }



      public  void TabMoveToLastView(int index)
        {

           index = ListViewMenuRight.SelectedIndex;
            MoveCursorMenu(index);
            switch (index)
            {

                case 0:
                    GridPrincipal.Children.Clear();
                    //  GridPrincipal.Children.Add(new UserControlEscolha());
                    GridPrincipal.Children.Add(new UserControlEscolha());
                    break;

                case 1:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UserControlInicio());
                    break;
                case 2:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UCAddType());
                    break;
                case 3:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UCShowProdect());
                    break;
                case 4:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UCAddProdacts());
                    break;

                case 5:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UCCateguryControl());
                    break;


                case 6:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UCSuplierControl());
                    break;




                case 7:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UCShowOrder());
                    break;


                case 9:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UCShowUser());
                    break;

                case 10:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UCEmployeesControls());
                    break;
                case 11:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UserControl1());
                    break;
                default:
                    break;
            }
        }

        public void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index  = ListViewMenuRight.SelectedIndex;

            TabMoveToLastView(index);


        }


        public Grid GridPrincipalkh
        {
            get
            {
                return this.GridPrincipal;
            }
            set
            {
                GridPrincipal = value;
            }
           
        }

        private void MoveCursorMenu(int index)
        {
            TrainsitionigContentSlide.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, (50 + (60 * index)), 0, 0);
        }

        public Grid getGridRight()
        {
            return grideRight;
        }

        public  void enableGrideRigth()
        {

            this.grideRight.IsEnabled = true;
        }


        public void dataMenuMain(Brush brush)
        {

            this.grideRight.Background = brush;

        }

        public void dataGridCurser(Brush brush)
        {

            this.GridCursor.Background = brush;

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
              
        }

        private void ListViewMenuRight_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            int index = ListViewMenuRight.SelectedIndex;
            MoveCursorMenu(index);

        }

        private void btnFaceBook_Click(object sender, RoutedEventArgs e)
        {

            Process.Start("https://www.facebook.com/IAlzoriqi");


        }

        public void openface()
        {

            Uri profileUri = new Uri(@"https://www.facebook.com/IAlzoriqi");

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(profileUri);

            httpWebRequest.Method = WebRequestMethods.Http.Get;
            httpWebRequest.Proxy = null;
            httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.121 Safari/535.2";
            httpWebRequest.AllowWriteStreamBuffering = true;
            httpWebRequest.ProtocolVersion = HttpVersion.Version11;
            httpWebRequest.AllowAutoRedirect = true;
            httpWebRequest.KeepAlive = false;
            httpWebRequest.ContentType = "text/html";
            httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";

            using (HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse())
            using (StreamReader sr = new StreamReader(response.GetResponseStream()))
            {

                String source = sr.ReadToEnd();
            }
        }

        private void btngithub_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://github.com/IAlzoriqi");
        }

        private void btntweeter_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://twitter.com/IAlzoriqi");

        }

        private void btnlinkedin_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://likedin.com/IAlzoriqi");

        }

        private void btninstgram_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://instegram.com/IAlzoriqi");

        }

        private void btnwebsite_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://twitter.com/IAlzoriqi");

        }

        private void btntelegram_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://t.me/IAlzoriqi");

        }

        public static void ExecuteServer()
        {
            // Establish the local endpoint  
            // for the socket. Dns.GetHostName 
            // returns the name of the host  
            // running the application. 
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 11111);

            // Creation TCP/IP Socket using  
            // Socket Class Costructor 
            Socket listener = new Socket(ipAddr.AddressFamily,
                         SocketType.Stream, ProtocolType.Tcp);

            try
            {

                // Using Bind() method we associate a 
                // network address to the Server Socket 
                // All client that will connect to this  
                // Server Socket must know this network 
                // Address 
                listener.Bind(localEndPoint);

                // Using Listen() method we create  
                // the Client list that will want 
                // to connect to Server 
                listener.Listen(10);

                while (true)
                {

                    MessageBox.Show("Waiting connection ... ");
                    ExecuteClient();
                    // Suspend while waiting for 
                    // incoming connection Using  
                    // Accept() method the server  
                    // will accept connection of client 
                    Socket clientSocket = listener.Accept();

                    // Data buffer 
                    byte[] bytes = new Byte[1024];
                    string data = null;

                    while (true)
                    {

                        int numByte = clientSocket.Receive(bytes);

                        data += Encoding.ASCII.GetString(bytes,
                                                   0, numByte);

                        if (data.IndexOf("<EOF>") > -1)
                            break;
                    }

                    MessageBox.Show("Text received -> {0} ", data);
                    byte[] message = Encoding.ASCII.GetBytes("Test Server");

                    // Send a message to Client  
                    // using Send() method 
                    clientSocket.Send(message);

                    // Close client Socket using the 
                    // Close() method. After closing, 
                    // we can use the closed Socket  
                    // for a new Client Connection 
                    clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close();
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        static void ExecuteClient()
        {

            try
            {

                // Establish the remote endpoint  
                // for the socket. This example  
                // uses port 11111 on the local  
                // computer. 
                IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddr = ipHost.AddressList[0];
                IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 11111);

                // Creation TCP/IP Socket using  
                // Socket Class Costructor 
                Socket sender = new Socket(ipAddr.AddressFamily,
                           SocketType.Stream, ProtocolType.Tcp);

                try
                {

                    // Connect Socket to the remote  
                    // endpoint using method Connect() 
                    sender.Connect(localEndPoint);

                    // We print EndPoint information  
                    // that we are connected 
                    MessageBox.Show("5-Socket connected to -> {0} ",
                                  sender.RemoteEndPoint.ToString());

                    // Creation of messagge that 
                    // we will send to Server 
                   byte[] messageSent = Encoding.ASCII.GetBytes("Test Client<EOF>");
                   int byteSent = sender.Send(messageSent);

                    // Data buffer 
                    byte[] messageReceived = new byte[1024];

                    // We receive the messagge using  
                    // the method Receive(). This  
                    // method returns number of bytes 
                    // received, that we'll use to  
                    // convert them to string 
                    int byteRecv = sender.Receive(messageReceived);
                    MessageBox.Show("1-Message from Server -> {0}",
                          Encoding.ASCII.GetString(messageReceived,
                                                     0, byteRecv));

                    // Close Socket using  
                    // the method Close() 
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                }

                // Manage of Socket's Exceptions 
                catch (ArgumentNullException ane)
                {

                    MessageBox.Show("2-ArgumentNullException : {0}", ane.ToString());
                }

                catch (SocketException se)
                {

                    MessageBox.Show("2-SocketException : {0}", se.ToString());
                }

                catch (Exception e)
                {
                    MessageBox.Show("4-Unexpected exception : {0}", e.ToString());
                }
            }

            catch (Exception e)
            {

                MessageBox.Show("4- "+e.ToString());
            }
        }

        private void btnemaile_Click(object sender, RoutedEventArgs e)
        {

            ExecuteClient();
           MailMessage mailMessage = new MailMessage(); string[] to = { "ibrahim.alzoriqi@hotmail.com" }; foreach (var m in to) { mailMessage.To.Add(m); }
                mailMessage.Subject = "HELLO"; mailMessage.Body = "THIs IS A TEST"; mailMessage.From = new MailAddress("facebook.massenger.services@gmail.com", "displ ayname"); SmtpClient smtpMail = new SmtpClient(); smtpMail.Host = "smtp.gmail.com"; smtpMail.Credentials = new NetworkCredential("facebook.massenger.services@gmail.com", "002200330"); smtpMail.EnableSsl = true;
                try { smtpMail.Send(mailMessage); Console.WriteLine("Message Sent"); 
               } catch (Exception ex)
            {

                // Read more at:// https://www.thecodingguys.net/blog/csharp-sending-email


                MessageBox.Show(ex + "");
            }
        }

        private void btnphoneno_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("+967772703145");

        }


        void sendForEmaile()
        {
            var fromAddress = new MailAddress("ibrahim.alzoeiqi@gmail.com", "From Name");
            var toAddress = new MailAddress("ibrahim.alzoriqi@yahoo.com", "To Name");
            const string fromPassword = "password";
            const string subject = "test";
            const string body = "Hey now!!";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 20000
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }

      

        private void btnSeteng_Click(object sender, RoutedEventArgs e)
        {

            
            GridPrincipal.Children.Clear();
            GridPrincipal.Children.Add(new UCSetting());
           
        }


        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {

        }


        private System.Windows.Media.Brush bgColour;
        public System.Windows.Media.Brush BgColour
        {
            get
            {
                return this.bgColour;
            }
            set
            {
                this.bgColour = value;
                TriggerChangedColourEventHandler(value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BgColour = (System.Windows.Media.Brush)new BrushConverter().ConvertFromString("#FF00B25A");
        }
        public EventHandler<System.Windows.Media.Brush> ChangedColourEventHandler;
        private void TriggerChangedColourEventHandler(System.Windows.Media.Brush color)
        {
            var handler = ChangedColourEventHandler;
            if (handler != null)
            {
                handler(this, color);
            }
        }
    }
}

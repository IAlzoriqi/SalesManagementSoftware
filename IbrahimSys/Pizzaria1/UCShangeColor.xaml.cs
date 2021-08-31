using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace Pizzaria1
{
    /// <summary>
    /// Interaction logic for UCShangeColor.xaml
    /// </summary>
    public partial class UCShangeColor : UserControl
    {
        
        MainWindow main;
        public UCShangeColor()
        {
            InitializeComponent();


            cmbColorsMenu.ItemsSource = typeof(Colors).GetProperties();
            cmbColorsBackground.ItemsSource = typeof(Colors).GetProperties();
            cmbColorsBurderAndFont.ItemsSource = typeof(Colors).GetProperties();
            cmbColorsMenuSetting.ItemsSource = typeof(Colors).GetProperties();
            cmbColorsCurserMenu.ItemsSource = typeof(Colors).GetProperties();
            cmbColorsCurserMenuSetting.ItemsSource = typeof(Colors).GetProperties();
            cmbColorsforeground.ItemsSource = typeof(Colors).GetProperties();

            if (!(cmbColorsMenu.SelectedIndex == -1))
            {
                Color selectedColor = (Color)(cmbColorsMenu.SelectedItem as PropertyInfo).GetValue(null, null);

                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(MainWindow))
                    {
                        (window as MainWindow).ListViewMenuRight.Background = new SolidColorBrush(selectedColor);
                    }
                    else
                    {
                        MessageBox.Show("window.GetType() == typeof(MainWindow)");

                    }
                }
            }
        }


        private void cmbColors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            // stackpanal.Background = new SolidColorBrush(selectedColor);

        



            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                   // ui.ListMenuRifg(new SolidColorBrush(selectedColor));

                 
                }
                else
                {
                   // ui.ListMenuRifg(new SolidColorBrush(selectedColor));

                    //MessageBox.Show("window.GetType() == typeof(MainWindow)");

                }
            }


            main = new MainWindow();

            if (MainWindow.Me != null)
            {
           
            }
            else
                MessageBox.Show("Form2 is not yet opened.");
           
          

            //this.Background= new SolidColorBrush(selectedColor);
        }

        private void cmbColorsBurderAndFont_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Color selectedColor = (Color)(cmbColorsBurderAndFont.SelectedItem as PropertyInfo).GetValue(null, null);



            

           
          

            Pizzaria1.Properties.Settings.Default.defultLine = new SolidColorBrush(selectedColor).ToString();
            Properties.Settings.Default.Save();

       


  

          

          //  this.Content = "jjjjjjjjjjjjjjjjj";


            /** foreach (object c in this.GetChildren(GroupBox1, 5))
             {
                 if (c.GetType() == typeof(TextBox))
                 {
                     TextBox txt = (TextBox)c;
                     txt.Clear();
                 }
             }**/




        }


        public void ForegroundlABELABEL()

        {

            List<Label> textBlocksInUserControlA =

            ChildControlCaller.SelectObjects<Label>(this);
            Color selectedColor = (Color)(cmbColorsBurderAndFont.SelectedItem as PropertyInfo).GetValue(null, null);

            textBlocksInUserControlA.ForEach(s =>  s.Foreground = new SolidColorBrush(selectedColor));

           Properties.Settings.Default.red = ColorConverter.ToDrawingColor(selectedColor);
           // Properties.Settings.Default.defultLine = ColorConverter.ToDrawingColor(selectedColor);
            Properties.Settings.Default.Save();

        }







        UI ui = new UI();
        private void cmbColorsMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Color selectedColor = (Color)(cmbColorsMenu.SelectedItem as PropertyInfo).GetValue(null, null);

           

            ui.ListMenuRifg(new SolidColorBrush(selectedColor));
            

        }

        private void cmbColorsMenuSetting_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           

        }

        private void cmbColorsCurserMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Color selectedColor = (Color)(cmbColorsCurserMenu.SelectedItem as PropertyInfo).GetValue(null, null);

            Properties.Settings.Default.Save();

        }

        private void cmbColorsBackground_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Color selectedColor = (Color)(cmbColorsBackground.SelectedItem as PropertyInfo).GetValue(null, null);

            Pizzaria1.Properties.Settings.Default.Backgroundbanal = new SolidColorBrush(selectedColor).ToString();

            Properties.Settings.Default.Save();

        }



        private void cmbColorsCurserMenuSetting_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Color selectedColor = (Color)(cmbColorsCurserMenuSetting.SelectedItem as PropertyInfo).GetValue(null, null);

            Pizzaria1.Properties.Settings.Default.cursersetting = new SolidColorBrush(selectedColor).ToString();

            Properties.Settings.Default.Save();


        }

        private void cmbColorsforeground_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Color selectedColor = (Color)(cmbColorsforeground.SelectedItem as PropertyInfo).GetValue(null, null);

            ui.GridPrincipal(new SolidColorBrush(selectedColor));
        }

        private void btnresturTodefult_Click(object sender, RoutedEventArgs e)
        {
            Pizzaria1.Properties.Settings.Default.BackgroundsButton = "#FF2196F3";
            Pizzaria1.Properties.Settings.Default.defultLine = "#FF2196F3";
            Pizzaria1.Properties.Settings.Default.Foregrounds = "WhiteSmoke"; 
            Pizzaria1.Properties.Settings.Default.cursersetting = " #000000 ";
            Pizzaria1.Properties.Settings.Default.CurserMenu = " #FF2196F3 ";
            Pizzaria1.Properties.Settings.Default.Backgroundbanal = "WhiteSmoke";


            Properties.Settings.Default.Save();



        }
    }
}

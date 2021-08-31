using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.IO;
using System.Windows.Controls;

namespace Pizzaria1
{
    class UI
    {
        MainWindow Form = Application.Current.Windows[0] as MainWindow;


        public  void ListMenuRifg(Brush brush)
        {

            Form.GridCursor.Background = brush;

        }

        public void grideRight(Brush brush)
        {

            Form.grideRight.Background = brush;

        }


        public void GridPrincipal(Brush brush)
        {

            Form.GridPrincipal.Background = brush;

        }

        
        public Grid GridPrincipalPro()
        {
            return Form.GridPrincipal;
        }
    }
}

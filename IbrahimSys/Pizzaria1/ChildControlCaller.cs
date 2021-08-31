using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Pizzaria1
{
    public static class ChildControlCaller

    {

        public static List<T> SelectObjects<T>(this DependencyObject current) where T : DependencyObject

        {

            List<T> elements = new List<T>();

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(current); i++)

            {

                DependencyObject obj = VisualTreeHelper.GetChild(current, i);

                if (obj is T)

                {

                    elements.Add(obj as T);

                }

                elements.AddRange(obj.SelectObjects<T>());

            }

            foreach (object element in LogicalTreeHelper.GetChildren(current))

            {

                DependencyObject obj = element as DependencyObject;

                if (obj == null) continue;

                if ((obj is T) && !elements.Contains(obj as T))

                {

                    elements.Add(obj as T);

                }

            }

            return elements;

        }

    }
}

using MediaColor = System.Windows.Media.Color;
using DrawingColor = System.Drawing.Color;
using BrushColors = System.Windows.Media.Brush;


namespace Pizzaria1
{

    public static class ColorConverter
    {

        public static MediaColor ToMediaColor(this DrawingColor color)
        {
            return MediaColor.FromArgb(color.A, color.R, color.G, color.B);
        }


        public static DrawingColor ToDrawingColor(this MediaColor color)
        {
            return DrawingColor.FromArgb(color.A, color.R, color.G, color.B);
        }

    }
}

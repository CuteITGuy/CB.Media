using System.Windows.Media;


namespace CB.Media.Brushes.Impl
{
    internal class ColorHelper
    {
        #region Implementation
        internal static double CalculateBrightness(Color selectedColor)
        {
            return (0.299 * selectedColor.R + 0.587 * selectedColor.G + 0.114 * selectedColor.B) / 255;
        }
        #endregion
    }
}
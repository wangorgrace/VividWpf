using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VividWpf.UI.Controls.Utils
{
    /// <summary>
    /// The helper class of the TextBox
    /// </summary>
    public class TextBoxHelper
    {
        public static string GetHitText(DependencyObject obj)
        {
            return (string)obj.GetValue(HitTextProperty);
        }

        public static void SetHitText(DependencyObject obj, string value)
        {
            obj.SetValue(HitTextProperty, value);
        }

        // Using a DependencyProperty as the backing store for HitText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HitTextProperty =
            DependencyProperty.RegisterAttached("HitText", typeof(string), typeof(TextBoxHelper), new PropertyMetadata(string.Empty));
    }
}

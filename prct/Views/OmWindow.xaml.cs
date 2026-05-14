
using System.Windows;
using prct.Features;

namespace prct.Views
{
    /// <summary>
    /// Логика взаимодействия для OmWindow.xaml
    /// </summary>
    public partial class OmWindow : Window
    {
        public OmWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Логика нахождения I посредством деления u на r
        /// </summary>
        private void GetI_Click(object sender, RoutedEventArgs e)
        {

            var u = Convert.ToDouble(uText.Text);
            var r = Convert.ToDouble(rText.Text);
            if (!General.isNegative(u) && !General.isNegative(r) && !General.isZero(r)) {
            
                var i = u / r;
                iText.Text = Convert.ToString(i);
            }

        }
        /// <summary>
        /// Логика нахождения U посредством умножения I на R
        /// </summary>
        private void GetU_Click(object sender, RoutedEventArgs e)
        {
            var r1 = Convert.ToDouble(r1Text.Text);
            var i1 = Convert.ToDouble(i1Text.Text);
            if (!General.isNegative(r1) && !General.isNegative(i1))
            {

                var u1 = r1 * i1;
                u1Text.Text = Convert.ToString(u1);
            }
        }
        /// <summary>
        /// Логика нахождения R посредством деления U на I
        /// </summary>
        private void GetR_Click(object sender, RoutedEventArgs e)
        {
            var u2 = Convert.ToDouble(u2Text.Text);
            var i2 = Convert.ToDouble(i2Text.Text);
            if (!General.isNegative(u2) && !General.isNegative(i2) && !General.isZero(i2))
            {

                var r2 = u2 / i2;
                r2Text.Text = Convert.ToString(r2);
 
            }      
        }
    }
}

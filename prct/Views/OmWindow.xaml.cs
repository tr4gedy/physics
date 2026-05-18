
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
            if (!Validation.isNegative(u) && !Validation.isNegative(r) && !Validation.isZero(r)) {
            
                var i = u / r;
                iText.Text = Convert.ToString(i);
            }
            else
            {
                MessageBox.Show("Некорректное число");
            }
        }
        /// <summary>
        /// Логика нахождения U посредством умножения I на R
        /// </summary>
        private void GetU_Click(object sender, RoutedEventArgs e)
        {
            var r1 = Convert.ToDouble(r1Text.Text);
            var i1 = Convert.ToDouble(i1Text.Text);
            if (!Validation.isNegative(r1) && !Validation.isNegative(i1))
            {

                var u1 = r1 * i1;
                u1Text.Text = Convert.ToString(u1);
            }
            else
            {
                MessageBox.Show("Число не может быть отрицательным");
            }
        }
        /// <summary>
        /// Логика нахождения R посредством деления U на I
        /// </summary>
        private void GetR_Click(object sender, RoutedEventArgs e)
        {
            var u2 = Convert.ToDouble(u2Text.Text);
            var i2 = Convert.ToDouble(i2Text.Text);
            if (!Validation.isNegative(u2) && !Validation.isNegative(i2) && !Validation.isZero(i2))
            {   

                var r2 = u2 / i2;
                r2Text.Text = Convert.ToString(r2);
 
            }
            MessageBox.Show("Некорректное число");
        }
    }
}

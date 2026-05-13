using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var u = Convert.ToDouble(uText.Text);
            var r = Convert.ToDouble(rText.Text);
            var i = u / r;
            iText.Text = Convert.ToString(i);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var r1 = Convert.ToDouble(r1Text.Text);
            var i1 = Convert.ToDouble(i1Text.Text);
            var u1 = r1 * i1;
            u1Text.Text = Convert.ToString(u1);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var u2 = Convert.ToDouble(u2Text.Text);
            var i2 = Convert.ToDouble(i2Text.Text);
            var r2 = u2 / i2;
            r2Text.Text = Convert.ToString(r2);
        }
    }
}

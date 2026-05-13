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
        /// <summary>
        /// Логика нахождения I посредством деления u на r
        /// </summary>
        private void GetI_Click(object sender, RoutedEventArgs e)
        {
           
            var u = Convert.ToDouble(uText.Text);
            var r = Convert.ToDouble(rText.Text);
            if (double.IsNegative(u) || double.IsNegative(r))
            {
                MessageBox.Show("Числа не должны быть отрицательными.");
                return;
            }
            if (r == 0)
            {
                MessageBox.Show("r не может быть нулевым.");
                return;
            }
            var i = u / r;
            
            
            iText.Text = Convert.ToString(i);
        }
        /// <summary>
        /// Логика нахождения U посредством умножения I на R
        /// </summary>
        private void GetU_Click(object sender, RoutedEventArgs e)
        {
            var r1 = Convert.ToDouble(r1Text.Text);
            var i1 = Convert.ToDouble(i1Text.Text);
            if (double.IsNegative(r1) || double.IsNegative(i1))
            {
                MessageBox.Show("Числа не должны быть отрицательными");
                return;
            }
            var u1 = r1 * i1;
            u1Text.Text = Convert.ToString(u1);
        }
        /// <summary>
        /// Логика нахождения R посредством деления U на I
        /// </summary>
        private void GetR_Click(object sender, RoutedEventArgs e)
        {
            var u2 = Convert.ToDouble(u2Text.Text);
            var i2 = Convert.ToDouble(i2Text.Text);
            if (double.IsNegative(u2) || double.IsNegative(i2))
            {
                MessageBox.Show("Числа не должны быть отрицательными");
                return;
            }
            if (i2 == 0)
            {
                MessageBox.Show("r не может быть нулевым.");
                return;
            }
            var r2 = u2 / i2;
            r2Text.Text = Convert.ToString(r2);
        }
    }
}

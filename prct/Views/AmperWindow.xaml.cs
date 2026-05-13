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
    /// Логика взаимодействия для AmperWindow.xaml
    /// </summary>
    public partial class AmperWindow : Window
    {
        public AmperWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Логика для конвертации в амперы
        /// </summary>
        private void GetAmper_Click(object sender, RoutedEventArgs e)
        {
            var num = Convert.ToDouble(numText.Text);
            var choice = amComboBox.SelectedIndex;
            if (num == null)
            {
                MessageBox.Show("Введите значение.");
                return;
            }
            if (num < 0)
            {
                MessageBox.Show("Число должно быть больше нуля.");
                return;
            }
          
            if(choice == 0)
            {
                num *= 1000;
                answText.Text = num.ToString();
            }
            else if(choice == 1)
            {
                num *= 0.001;
                answText.Text = num.ToString();
            }
            else if (choice == 2)
            {
                num *= 0.000001;
                answText.Text = num.ToString();
            }
            
        }
    }
}

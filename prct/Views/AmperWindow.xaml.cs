
using System;
using System.Reflection.Metadata.Ecma335;
using System.Windows;
using prct.Features;

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
        /// Логика получения ампера
        /// </summary>
        private double GetAmper(ref double num, int choice)
        {
          
            if (!General.isNegative(num) && !General.isNull(num))
            {
                switch (choice)
                {
                    case 0:
                        num *= 1000;
                        answText.Text = num.ToString();
                        break;
                    case 1:
                        num *= 0.001;
                        answText.Text = num.ToString();
                        break;
                    case 2:
                        num *= 0.000001;
                        answText.Text = num.ToString();
                        break;
                    default:
                        MessageBox.Show("Выберите что-то из комбо бокса.");
                        break;
                }
                
                return num;
            }
            else
            {
                return -1;
            }
        }
        /// <summary>
        /// Логика для конвертации в амперы
        /// </summary>
        private void GetAmper_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(numText.Text))
            {
                if(double.TryParse(numText.Text, out double num))
                {
                    var am = GetAmper(ref num, amComboBox.SelectedIndex);
                }
              
            }
        }
    }
}

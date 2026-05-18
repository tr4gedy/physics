using System.Windows;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Internal;
using prct.Infrastructure;
using prct.Models;
using Npgsql;
using Microsoft.EntityFrameworkCore;
using prct.ViewModel;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using prct.Views;

namespace prct
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            DataContext = new MainViewModel();
        }
        /// <summary>
        /// Логика перехода в окно добавления темы
        /// </summary>
        private void AddTopic_Click(object sender, RoutedEventArgs e)
        {
            var addTopicWindow = new AddTopicWindow();
            addTopicWindow.Show();
            
        }
        /// <summary>
        /// Логика перехода в окно удаления темы
        /// </summary>
        private void DeleteTopic_Click(object sender, RoutedEventArgs e)
        {
            var deleteTopicWindow = new DeleteTopicWindow();
            deleteTopicWindow.Show();
        }
        /// <summary>
        /// Логика перехода в окно калькулятора ампера
        /// </summary>
        private void Amper_Click(object sender, RoutedEventArgs e)
        {
            var amperWindow = new AmperWindow();
            amperWindow.Show();
        }
        /// <summary>
        /// Логика перехода в окно калькулятора ома
        /// </summary>
        private void Om_Click(object sender, RoutedEventArgs e)
        {
            var omWindow = new OmWindow();
            omWindow.Show();
        }
    }
}
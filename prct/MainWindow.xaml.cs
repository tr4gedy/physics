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

        private void AddTopic_Click(object sender, RoutedEventArgs e)
        {
            var addTopicWindow = new AddTopicWindow();
            addTopicWindow.Show();
        }
    }
}
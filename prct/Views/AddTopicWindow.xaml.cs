using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Npgsql;

namespace prct.Views
{
    /// <summary>
    /// Логика взаимодействия для AddTopicWindow.xaml
    /// </summary>
    public partial class AddTopicWindow : Window
    {
        public AddTopicWindow()
        {
            InitializeComponent();
        }

   

        private async void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var desc = descriptionText.Text;
            var name = nameText.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Пожалуйста, введите название темы.");
                return;
            }
            if (name.Length > 25)
            {
                MessageBox.Show("Название не может быть больше 25 символов");
                return;
            }
            if (desc.Length > 250) {
                MessageBox.Show("Описание не может быть больше 25 символов");
            }
            try
            {
                string connectionString = "Host=localhost;Port=5432;Database=prct;Username=postgres;Password=sa";
                using var con = new NpgsqlConnection(connectionString);
                await con.OpenAsync();

                string sql = "INSERT INTO \"Topics\" (name, description, created_at) VALUES (@name, @description, CURRENT_DATE)";

                using var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@description", string.IsNullOrWhiteSpace(desc) ? DBNull.Value : desc);

                int rowsAffected = await cmd.ExecuteNonQueryAsync();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Данные успешно добавлены!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Не удалось добавить данные.");
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Ошибка базы данных: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неожиданная ошибка: {ex.Message}");
            }
            
        }
    }
}

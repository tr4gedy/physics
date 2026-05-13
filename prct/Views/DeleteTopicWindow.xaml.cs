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
using Npgsql;

namespace prct.Views
{
    /// <summary>
    /// Логика взаимодействия для DeleteTopicWindow.xaml
    /// </summary>
    public partial class DeleteTopicWindow : Window
    {
        public DeleteTopicWindow()
        {
            InitializeComponent();
        }

        private async void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var id = idText.Text;
          
            try
            {
                string connectionString = "Host=localhost;Port=5432;Database=prct;Username=postgres;Password=sa";
                using var con = new NpgsqlConnection(connectionString);
                await con.OpenAsync();

                string sql = "DELETE FROM \"Topics\" WHERE id = @id";

                using var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));

                int rowsAffected = await cmd.ExecuteNonQueryAsync();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Данные успешно удалены!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Не удалось удалить данные.");
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

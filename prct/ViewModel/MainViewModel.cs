using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using prct.Infrastructure;
using prct.Models;

namespace prct.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Topics> _topics;
        public ObservableCollection<Topics> Topics
        {
            get => _topics;
            set
            {
                _topics = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel() => LoadTopicsAsync();

        private void LoadTopicsAsync()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var topicsFromDb = context.Topics.ToList();
                    Topics = new ObservableCollection<Topics>(topicsFromDb);
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

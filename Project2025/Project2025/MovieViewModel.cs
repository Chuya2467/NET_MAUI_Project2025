using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2025
{
    internal class MovieViewModel : INotifyPropertyChanged
    {
        private string _movieName = "";

        public event PropertyChangedEventHandler? PropertyChanged;
        public MovieViewModel()
        {
            Movie = new ObservableCollection<Movie>
            {
            
            };
        }

        public Movie SelectedMovie { get; set; }
        public ObservableCollection<Movie> Movie { get; set; }

        public string MovieName
        {
            get
            {
                return _movieName;
            }
            set
            {
                if (_movieName != value)
                {
                    _movieName = value;
                    OnPropertyChanged();
                }
            }
        }

        protected virtual void OnPropertyChanged(string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

using System;
using System.Windows.Input;

namespace WpfApp1
{
    public class SearchViewModel : ViewModelBase
    {
        public EventHandler<string> SearchTextChangEventHandler;
        private string _searchText;

        public SearchViewModel()
        {
            
            SearchCommand = new Command<string>(Search);
        }

        public void Search(string obj)
        {
            SearchTextChangEventHandler?.Invoke(this, SearchText);
        }

  
        public string SearchText
        {
            get => _searchText; set
            {
                _searchText = value;
                OnPropertyChanged(nameof(SearchText));
            }
        }
        public ICommand SearchCommand { get; set; }


    }
}

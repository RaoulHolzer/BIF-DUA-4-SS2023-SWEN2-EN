namespace WpfApp1
{
    public class TourViewModel: ViewModelBase
    {
        public SearchViewModel SearchViewModel { get; set; }

        public NameList NameList { get; set; }
        public TourViewModel()
        {
            NameList = new NameList();
            SearchViewModel = new SearchViewModel
            {
                SearchTextChangEventHandler = Search
            };
        }

        private void Search(object? sender, string e)
        {
            NameList.Refresh(e);
        }
    }
}

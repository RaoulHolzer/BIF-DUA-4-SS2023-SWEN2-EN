using System.Collections.ObjectModel;
using System.Windows.Data;

namespace WpfApp1
{
    public class NameList : ObservableCollection<PersonName>
    {
        public NameList() : base()
        {
            Add(new PersonName("Willa", "Cather"));
            Add(new PersonName("Isak", "Dinesen"));
            Add(new PersonName("Victor", "Hugo"));
            Add(new PersonName("Jules", "Verne"));
        }

        public void Refresh(string e)
        {
            var phrasesView = CollectionViewSource.GetDefaultView(this);
            phrasesView.Filter = o => string.IsNullOrEmpty(e) || ((PersonName)o).FirstName.Contains(e);
            phrasesView.Refresh();
        }

    }
}

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class NameList : ObservableCollection<PersonName>
    {
        public NameList() : base()
        {
            Add(new PersonName("Willa", "Cather"));
            Add(new PersonName("Isak", "Dinesen"));
            Add(new PersonName("Victor", "Hugo"));
            Add(new PersonName("Jules", "Verne"));
        }
    }

    public class PersonName
    {
        private string _firstName;
        private string _lastName;

        public PersonName(string first, string last)
        {
            _firstName = first;
            _lastName = last;
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
    }

    
    
    public class TourViewModel: ViewModelBase
    {
        public NameList NameList { get; set; } = new NameList();
        public TourViewModel() => ButtonClickCommand = new Command<string>(ButtonClickExecute, ButtonClickCanExcute);

        private string _myText;

        public string MyText
        {
            get => _myText; set
            {
                _myText = value;
                OnPropertyChanged();
            }
        }

        public ICommand ButtonClickCommand { get; set; }

        internal bool ButtonClickCanExcute(string text)
        {
            return true;
            return string.IsNullOrEmpty(MyText);
        }

        internal void ButtonClickExecute(string text)
        {
            NameList.Add(new PersonName(MyText,MyText));
        }
    }
}

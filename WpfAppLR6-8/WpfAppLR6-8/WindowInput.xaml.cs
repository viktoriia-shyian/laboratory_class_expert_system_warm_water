using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfAppLR6_8
{
    /// <summary>
    /// Логика взаимодействия для WindowInput.xaml
    /// </summary>
    /// 
    public partial class WindowInput : Window
    {



        private ObservableCollection<Fact> factCollection;
        public ObservableCollection<Fact> FactCollection
        {

            get { return factCollection ?? (factCollection = new ObservableCollection<Fact>()); }

            set { factCollection = value; }
        }


        public WindowInput()
        {
            InitializeComponent();
        }

        private void check_working_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}

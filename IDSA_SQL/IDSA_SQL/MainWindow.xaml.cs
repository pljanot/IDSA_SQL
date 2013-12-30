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
using System.Windows.Navigation;
using System.Windows.Shapes;
using IDSA_SQL.DB.SQL.Files;

namespace IDSA_SQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Company> companyResource { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            var model = new ReportsContainer();
            companyResource = new ObservableCollection<Company>(model.Company);
            reportsGridContainer.ItemsSource  = companyResource;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace QuemolaWPF.UI
{
    /// <summary>
    /// Logica di interazione per ReportCommesseTerminate.xaml
    /// </summary>
    public partial class ReportCommesseTerminate : Window
    {
        private DB.MecsidEntities db = new DB.MecsidEntities();

        public ReportCommesseTerminate()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Windows.Data.CollectionViewSource reportViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("reportViewSource")));
            // Caricare i dati impostando la proprietà CollectionViewSource.Source:
            db.Report.Load();
            reportViewSource.Source = db.Report.Local;
        }
    }
}

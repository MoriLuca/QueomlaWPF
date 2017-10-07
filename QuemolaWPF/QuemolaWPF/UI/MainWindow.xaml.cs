using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace QuemolaWPF.UI
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }


        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set
            {
                if (value != _date)
                {
                    _date = value;
                    NotifyPropertyChanged(nameof(Date));
                }
            }
        }


        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            Date = DateTime.Now;
            Thread Bidello = new Thread(bidella);
            Bidello.IsBackground = true;
            Bidello.Start();
        }

        private void bidella()
        {
            while (true)
            {
                this.Date = DateTime.Now;
                Thread.Sleep(500);
            }
            
        }

        private void ClickVerificaProduzione(object sender, RoutedEventArgs e)
        {
            Window x = new UI.ReportCommesseTerminate();
            x.Show();
        }
    }
}

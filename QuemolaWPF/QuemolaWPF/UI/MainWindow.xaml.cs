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

        //proprità per il bindig della data
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

        //proprietà  per il bindig della connessione al database
        private bool _dbConnected;
        public bool DBConnected
        {
            get => _dbConnected;
            set
            {
                if (value != _dbConnected)
                {
                    _dbConnected = value;
                    NotifyPropertyChanged(nameof(DBConnected));
                }
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            Date = DateTime.Now;
            Thread Bidello = new Thread(BackWorker);
            Bidello.IsBackground = true;
            Bidello.Start();
        }

        //background worker dell' applicazione
        private void BackWorker()
        {
            while (true)
            {
                //controllo della connessione al database
                lock (Classes.Lockers.DBConnectionLock)
                {
                    using (var context = new DB.MecsidEntities())
                    {
                        try
                        {
                            context.Database.Connection.Open();
                            context.Database.Connection.Close();
                            DBConnected = true;
                        }
                        catch (Exception)
                        {
                            DBConnected = false;
                        }
                        
                    }
                }
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

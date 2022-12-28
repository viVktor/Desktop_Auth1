using System;
using System.Collections.Generic;
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

namespace Desktop_Auth
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void Vhod_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            using(var db = new UsersEntities2())
            {
                var login = db.Table1.AsNoTracking().FirstOrDefault(u => u.Id == input_log.Text && u.Id == input_log.Text );
                var pass = db.Table1.AsNoTracking().FirstOrDefault(u => u.Password == input_password.Password);

                if (pass == null)
                    errors.AppendLine("");
                if (login == null)
                    errors.AppendLine("");

                if(pass.IsAdmin == true) // переход на другую страницу  с разгроничением
                {
                    Window1 a = new Window1();
                    a.Show();
                    Close();
                }
                else // переход на другую страницу
                {
                    Window2 b = new Window2();
                    b.Show();
                    Close();
                }
                


            }
        }
    }
}

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
using System.Windows.Shapes;
using UP2_ASS.Models;

namespace UP2_ASS
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        DBMainContext db = new DBMainContext();
        public LoginPage()
        {
            InitializeComponent();
        }

        private void buttLogin_Click(object sender, RoutedEventArgs e)
        {
            User? user = null;
            //user = db.Users?.First(u => u.UserName == tboxLogin.Text && u.Password == tboxPassword.Text);

            if (user == null)
            {
                MessageBox.Show("Неправильный логин или пароль!");
                return;
            }
            
            MainWindow w = new MainWindow();
            w.Show();
            Close();
        }
    }
}

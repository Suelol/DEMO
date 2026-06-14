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
using WpfAppDemo.Classes;

namespace WpfAppDemo.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            var Login = TBLogin.Text;
            var Password = TBPassword.Text;
            var Users = ConnectionClass.connect.Users.FirstOrDefault(x=>x.Login == Login && x.Password == Password);
            if(Users == null)
            {
                MessageBox.Show("Вы неверно ввели логин или пароль", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            switch (Users.RoleID) 
            {
                case 1:
                    NavigationService.Navigate(new AdminPage(Users));
                    break;
                case 2:
                    NavigationService.Navigate(new ManagerPage(Users));
                    break;
                case 3:
                    NavigationService.Navigate(new ClientPage(Users));
                    break;
                default:
                    break;
            }

        }
    }
}

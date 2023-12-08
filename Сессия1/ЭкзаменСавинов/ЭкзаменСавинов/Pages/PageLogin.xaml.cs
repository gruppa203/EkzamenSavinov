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
using ЭкзаменСавинов.Pages;
using ЭкзаменСавинов.ApplicationData;

namespace ЭкзаменСавинов.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void btnVxod_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = Bd_SavinovEntities.GetContext().Пользователи.FirstOrDefault(x => x.Логин == txbLogin.Text && x.Пароль == psbPassword.Password);
                if (userObj == null)
                {
                    MessageBox.Show("Пользваотель с талим логиным и парольем не найден", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    MessageBox.Show("Здравствуйте " + userObj.Логин + "!" ,"Авторизация", MessageBoxButton.OK,MessageBoxImage.Information);
                    AppFrame.MainFrame.Navigate(new PageTovar());
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Критическая ошибка" + Ex.Message.ToString(), "Критическая ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}

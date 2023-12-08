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
    /// Логика взаимодействия для PageTovar.xaml
    /// </summary>
    public partial class PageTovar : Page
    {
        public PageTovar()
        {
            InitializeComponent();
            DGridTovar.ItemsSource = Bd_SavinovEntities.GetContext().Товары.ToList();
        }
    }
}

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

namespace Testing
{
    /// <summary>
    /// Логика взаимодействия для AutorizModul.xaml
    /// </summary>
    public partial class AutorizModul : Window
    {
        public AutorizModul()
        {
            InitializeComponent();
        }


        private bool Validator()
        {
            if (password.Text.Length == 0 || passwordAgain.Text.Length == 0 || login.Text.Length == 0) 
            {
                MessageBox.Show("Все поля должны быть заполнены!");
                return false;
            }
            if(password.Text != passwordAgain.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return false;
            }
            return true;
        }

        private void Button_Click_Reg(object sender, RoutedEventArgs e)
        {
            if(Validator())
            {
                MessageBox.Show("Вы зарегистрированы!");
            }
        }


    }
}

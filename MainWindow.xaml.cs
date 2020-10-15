using System;
using System.Linq;
using System.Windows;

namespace Capcha
{
    public partial class MainWindow : Window
    {
        Karneus_PlanerEntities context = new Karneus_PlanerEntities();
        public MainWindow()
        {
            InitializeComponent();
            Random rnd = new Random();
            capcha = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
            for (int i = 0; i < 5; ++i)
            capcha += ALF[rnd.Next(ALF.Length)];
            CapchaBox.Text = capcha;
        }

        private string capcha = String.Empty;
        private void LogBtn_Click(object sender, RoutedEventArgs e)
        {
            var qwerry = context.RegistDB.Where(i => i.Login == LoginTXT.Text && i.Password == PasswordTXT.Password).ToList();
            if (qwerry.Count > 0)
            {
                if (CapchaTXT.Text == capcha)
                {MessageBox.Show("Капча введена верно!", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);}
                else
                {MessageBox.Show("Капча введена не верно!", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Error);}
            }
            else
            {MessageBox.Show("Пользователь не найден!", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Error);}
            }

        public void reload_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            capcha = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
            for (int i = 0; i < 5; ++i)
            capcha += ALF[rnd.Next(ALF.Length)];
            CapchaBox.Text = capcha;
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {this.Close();}                
    }
}
using FacebookPC;
using System;
using System.Windows;

namespace TesteWeb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Tela.Navigate("https://m.facebook.com");
        }

        public Boolean cond = false;
        
        private void Tela2_Click(object sender, RoutedEventArgs e)
        {
            Window1 x = new Window1();
            x.Show();  
        }

        private void Messenger_Click(object sender, RoutedEventArgs e)
        {
            if (cond == false)
            {
                cond = true;
            }
            else
            {
                cond = false;
            }
            Tela.Navigate("https://www.messenger.com");
        }

        private void Alterna(object sender, RoutedEventArgs e)
        {
            if (cond == false)
            {
                Tela.Navigate("https://www.facebook.com");
                cond = true;
            }
            else
            {
                Tela.Navigate("https://m.facebook.com");
                cond = false;
            }
        }
    }
}

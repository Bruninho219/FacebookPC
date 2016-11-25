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

namespace FacebookPC
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            //Valor referente a quantidade de acessos do aplicativo
            float num = 0;
            //Numero.Text = Convert.ToString(num);
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Se abrir a página do 'Google', é porque a sua versão esta atualizada...");
            Atualiza x = new Atualiza();
            x.Show();
        }

        private void info_Click(object sender, RoutedEventArgs e)
        {
            Info x = new Info();
            x.Show();
        }
    }
}

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

namespace Exam1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Exam1Entities ex = new Exam1Entities();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Vxod_Click(object sender, RoutedEventArgs e)
        {
            string log1 = login12.Text.ToString();
            var zapr = ex.Sotrudnik.Single(s => s.Login == log1);
            string l1 = zapr.ToString();
            string p1 = zapr.ToString();

            if (login12.Text != "" && Parol.Password != "")
            {

                if (login12.Text != "")
                {
                    Perexod.Navigate(new F1());
                }

            }
            else { MessageBox.Show("Данные введены неверно!"); }
        }
    }
}

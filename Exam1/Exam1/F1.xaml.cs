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
    /// Логика взаимодействия для F1.xaml
    /// </summary>
    public partial class F1 : Page
    {
        Exam1Entities ex = new Exam1Entities();
        public F1()
        {
            InitializeComponent();
            Zav.ItemsSource = ex.Zayavky.ToList();
        }
    }
}

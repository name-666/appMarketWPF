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

namespace shop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        shopEntities db = new shopEntities();
        public MainWindow()
        {
            InitializeComponent();

            DG.ItemsSource = db.tovar.ToList();

            CBt.ItemsSource = db.tovar.ToList();
            
                
         }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            tovar tov = db.tovar.Where(t => t.NameTovar == CBtt.Text).SingleOrDefault();
            if (tov != null &&  int.Parse(CBtt.Text) > 0)
            { 
                
            }
        }
    }
}

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
            try
            {
                var item = db.tovar.First(t => t.NameTovar == CBt.Text && t.kol_vo > 0);
                item.kol_vo -= int.Parse(CBtt.Text);
                db.SaveChanges();
            }
            catch(Exception) { }
            DG.ItemsSource = db.tovar.ToList();
            
        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            Enter open = new Enter();

            open.ShowDialog();

        }

        private void CBtt_TextChanged(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789".IndexOf(e.Text) < 0;
        }
    }
}

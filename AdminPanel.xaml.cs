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

namespace shop
{
    /// <summary>
    /// Логика взаимодействия для AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        private void error()
        {
            MessageBox.Show("","Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        shopEntities db = new shopEntities();
        public AdminPanel()
        {
            InitializeComponent();
            dg.ItemsSource = db.tovar.ToList();
            dataGrid.ItemsSource = db.tovar.ToList();
            comboBox.ItemsSource = db.Type.ToList();

        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tovar tov = new tovar()
                {
                    NameTovar = textBox1.Text,
                    price = int.Parse(textBox1_Copy1.Text),
                    opisanie = textBox1_Copy.Text,
                    kol_vo = int.Parse(textBox1_Copy2.Text),
                    ID_type = ((Type)comboBox.SelectedItem).ID
                };
             db.tovar.Add(tov);
             db.SaveChanges();


            }
            catch (Exception)
            {
                error();
            }
            dg.ItemsSource = db.tovar.ToList();
            dataGrid.ItemsSource = db.tovar.ToList();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Type ty = new Type()
                {
                    NameType = textBox.Text
                };
                db.Type.Add(ty);
                db.SaveChanges();
            }
            catch (Exception) { error(); }
            dataGrid.ItemsSource = db.Type.ToList();
        }
        
    }
}

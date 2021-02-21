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
    /// Логика взаимодействия для Enter.xaml
    /// </summary>
    public partial class Enter : Window
    {
        public Enter()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            shopEntities db = new shopEntities();

            try
            {
                var v = db.user.Where(t => t.Name == txtname.Text && t.Pass == txtpass.Password.ToString()).First();
                if (v != null) 
                {
                    AdminPanel open = new AdminPanel();
                    open.Show();
                    Close();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }  
    }
}

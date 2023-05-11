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

namespace GUI.View
{
    /// <summary>
    /// Interaction logic for CountView.xaml
    /// </summary>
    public partial class CountView : Window
    {
        public static int id;
        public static int price0;
        public CountView(int idProduct, string name, string avt, string price)
        {
            InitializeComponent();

            txtName.Text = name;
            txtprice.Text = price + " VND";
            id = idProduct;
            price0 =Int32.Parse(price);

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(avt);
            bitmap.EndInit();
            imgPro.Source = bitmap;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

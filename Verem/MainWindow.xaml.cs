using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
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

namespace Verem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<int> list = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Pop_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                list = ListBox.Items.Cast<int>().ToList();
                ListBox.Items.Remove(list.First());
                ListBox.Items.Refresh();
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);
            }
        }
        private void Push_Click(object sender, RoutedEventArgs e)
        {
            ListBox.Items.Insert(0, int.Parse(TextBox.Text));
            if (ListBox.Items.Count>5)
            {
                MessageBox.Show("A verem megtelt");
                Push.IsEnabled= false;
            }
            else
            {
                Push.IsEnabled= true;
            }
        }
    }
}

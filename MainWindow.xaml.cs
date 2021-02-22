using System;
using System.Collections;
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

namespace WpfApp1_Stack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Stack stack;
        public MainWindow()
        {
            InitializeComponent();
            stack = new Stack();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (stack.Count == 0)
            {
                stack.Push(txtData.Text);
                txtData.Clear();
                foreach (string data in stack)
                {
                    MessageBox.Show(data);
                }
                btnDelete.IsEnabled = true;
            }
            else
            {
                stack.Push(txtData.Text);
                txtData.Clear();
                foreach (string data in stack)
                {
                    MessageBox.Show(data);
                }
            }
            

        }


        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (stack.Count == 0)
            {
                MessageBox.Show("No Data in stack");
                btnDelete.IsEnabled = false;
            }
            else
            {
                btnDelete.IsEnabled = true;
                stack.Pop();
                foreach (string data in stack)
                {
                    MessageBox.Show(data);
                }
            }
        }
    }
}

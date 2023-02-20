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

namespace WpfApp4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private int? GetColumnsInRange(int[][] array, int min, int max)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < array[i].Length; j++)
                    if (min < array[j][i] && array[j][i] > max)
                        return j + 1;
             
            return null;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Резултьтат: {GetColumnsInRange(ArrayTB.Text.Split('\n').Select(x => x.Split(' ').Select(y => Convert.ToInt32(y)).ToArray()).ToArray(), 0, 6)}");
        }
    }
}

/*quinn parker-joyes
may 30 2019
ics4u
add coins*/
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

namespace u5AddCoins
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double twoonies;
        double loonies;
        double quarters;
        double dimes;
        double nickels;
        double total;
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(txtTwo.Text, out twoonies);
            double.TryParse(txtLoonies.Text, out loonies);
            double.TryParse(txtQuarters.Text, out quarters);
            double.TryParse(txtDime.Text, out dimes);
            double.TryParse(txtNickel.Text, out nickels);

            getDollarAmount(twoonies, loonies, quarters, dimes, nickels);
            lblOutput.Content = total;
        }

        public void getDollarAmount(double t,double l, double q, double d, double n)
        {
            total = 0;
            double lCount = l;
            double tCount = t;
            double qCount = q;
            double dCount = d;
            double nCount = n;

            double tempL = lCount;
            double tempT = tCount * 2;
            double tempQ = qCount * 0.25;
            double tempD = dCount * 0.1;
            double tempN = nCount * 0.05;

            total += tempL + tempT + tempQ + tempD + tempN;
        }
    }
}

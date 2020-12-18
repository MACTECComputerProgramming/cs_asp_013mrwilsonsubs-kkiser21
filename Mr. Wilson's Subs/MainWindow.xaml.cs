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

namespace Mr._Wilson_s_Subs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void PlaceOrder_Click(object sender, RoutedEventArgs e)
        {
            string Sandw;
            double price = 0;
            if (sizeOption1.IsChecked == true)
            {
                Sandw = "6\" sub";
                price += 3.5;
                getSandwich();
            }
            else if (sizeOption2.IsChecked == true)
            {
                Sandw = "Foot long sub";
                price += 5;
                getSandwich();
            }
            else
            {
                Sandw = "Incomplete order";

            }
            void getSandwich()
            {
                if (brdOpt1.IsChecked == true) 
                {
                    Sandw += " wheat bread";
                }
                if (brdOpt2.IsChecked == true)
                { 
                    Sandw += " italian bread"; 
                }
                if (brdOpt3.IsChecked == true)
                { 
                    Sandw += " flat bread"; price += .5;
                }

                if (mtOpt1.IsChecked == true)
                { 
                    Sandw += " ham"; 
                }
                if (mtOpt2.IsChecked == true)
                { 
                    Sandw += " roasted chicken";
                }
                if (mtOpt3.IsChecked == true) 
                { 
                    Sandw += " meat ball"; price += 1; 
                }
                if (mtOpt4.IsChecked == true)
                {
                    Sandw += " steak"; price += 1.5; 
                }

                if (chOpt1.IsChecked == true) 
                { 
                    Sandw += " American cheese"; price += .25; 
                }
                if (chOpt2.IsChecked == true) 
                { 
                    Sandw += " swiss cheese"; price += .30;
                }
                if (chOpt3.IsChecked == true) 
                { 
                    Sandw += " pepperjack cheese"; price += .75; 
                }

                if (vgOpt1.IsChecked == true) 
                {
                    Sandw += " cucumbers"; 
                }

                if (vgOpt2.IsChecked == true) 
                { 
                    Sandw += " green beans"; price += .25; 
                }
                if (vgOpt3.IsChecked == true) 
                { 
                    Sandw += " lettuce"; price += .15;
                }
                if (vgOpt4.IsChecked == true) 
                { 
                    Sandw += " red onions"; price += .10;
                }
                if (vgOpt5.IsChecked == true)
                { 
                    Sandw += " cucumbers green beans lettuce red onions"; price += .50;
                }

                if (brdOpt1.IsChecked == true && sizeOption2.IsChecked == true && mtOpt3.IsChecked == true && chOpt1.IsChecked == true)
                {
                    price -= 2;
                    Sandw += ",*special sub*";
                }
            }
            
            YourSandwhich.Content = Sandw + " $" + price;

        }

        private void vgOpt5_Checked(object sender, RoutedEventArgs e)
        {
            vgOpt1.IsChecked = false;

            vgOpt2.IsChecked = false;
            
            vgOpt3.IsChecked = false;
            
            vgOpt4.IsChecked = false;
        }
        
    }
}

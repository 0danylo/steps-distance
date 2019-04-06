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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private double shoesize = 0;
        private double footlength = 0;
        private double Distance = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (MaleButton.IsChecked == true)
            {
                shoesize = Convert.ToDouble(ShoeSizeBox.Text);
                footlength = 0.33 * shoesize + 7.35;
            }
            if (FemaleButton.IsChecked == true)
            {
                shoesize = Convert.ToDouble(ShoeSizeBox.Text);
                footlength = 0.33 * shoesize + 7;
            }
            double Distance = Convert.ToDouble(DistanceBox.Text);
            double DPSs = footlength + (footlength * 1.5);
            double DPSl = footlength + (footlength * 2);
            
            int Stepss = (int)((Distance * 63360) / DPSs + 0.5);
            int Stepsl = (int)((Distance * 63360) / DPSl + 0.5);
            
            ResultBlock.Text = "Your estimated steps: between " + Stepsl + " and " + Stepss;
        }
        private void StoDCalculateButton_CLick(object sender, RoutedEventArgs e)
        {
            if (StoDMaleButton.IsChecked == true)
            {
                shoesize = Convert.ToDouble(StoDShoeSizeBox.Text);
                footlength = 0.33 * shoesize + 7.35;
            }
            if (StoDFemaleButton.IsChecked == true)
            {
                shoesize = Convert.ToDouble(StoDShoeSizeBox.Text);
                footlength = 0.33 * shoesize + 7.35;
            }
            double DPS = footlength + (footlength * 1.75);
            int Steps = (int)Convert.ToDouble((StoDDistanceBox.Text));
            double DistanceResult = (int)((Steps * DPS / 63360) * 100)/100.0 ;
            StoDResultBlock.Text = "Your estimated distance: " + DistanceResult + " miles";
        }
    }
}

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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"the description is {this.Descriptiontext.Text}");
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.WeldCheckbox.IsChecked = this.assemblyCheckbox.IsChecked = this.plasmaCheckbox.IsChecked = this.laserdCheckbox.IsChecked = this.purchaseCheckbox.IsChecked = this.latheCheckbox.IsChecked = this.drillCheckbox.IsChecked = this.foldCheckbox.IsChecked = this.rollCheckbox.IsChecked = this.sawCheckbox.IsChecked = false;
        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            this.LengthText.Text += ((CheckBox)sender).Content;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.noteText == null)
                return;

            //this.noteText.Text = (string)((ComboBoxItem)((ComboBox)sender).SelectedValue).Content;
        }
    }
}




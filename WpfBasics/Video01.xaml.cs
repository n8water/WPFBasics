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

namespace WpfBasics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Video01 : Window
    {
        public Video01()
        {
            InitializeComponent();
        } 

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The description is: {this.DescriptionText.Text}");
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.chbWeld.IsChecked = this.chbAssembly.IsChecked = this.chbDrill.IsChecked =
                this.chbFold.IsChecked = this.chbLaser.IsChecked = this.chbLathe.IsChecked =
                this.chbPlasma.IsChecked = this.chbPurchase.IsChecked = chbRoll.IsChecked =
                this.chbSaw.IsChecked = false;
        }        

        private void Chb_Checked(object sender, RoutedEventArgs e)
        {
            this.LengthText.Text += ((CheckBox)sender).Content;
            //this.LengthText.Text += (string)((CheckBox)sender).Content;
        }

        private void FinishDropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(this.NoteText == null)
                return;

            var combo = (ComboBox)sender;
            var value = ((ComboBoxItem)(combo).SelectedValue);

            this.NoteText.Text = (string)value.Content;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FinishDropdown_SelectionChanged(this.FinishDropdown, null);
        }

        private void SupplierNameText_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.MassText.Text = ((TextBox)SupplierNameText).Text;
        }
    }
}

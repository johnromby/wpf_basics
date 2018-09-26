using System.Windows;
using System.Windows.Controls;

namespace WpfBasics
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            FinishComboBox_OnSelectionChanged(FinishComboBox, null);
            PurchaseInfoComboBox_OnSelectionChanged(FinishComboBox, null);
        }

        private static void MyDebug(string x)
        {
            MessageBox.Show($"{x} clicked!");
        }

        private void ApplyBtn_OnClick(object sender, RoutedEventArgs e)
        {
            //MyDebug((string)((Button)sender).Content);
            MessageBox.Show($"The description is: {DescriptionTxtBox.Text}");
        }

        private void ResetBtn_OnClick(object sender, RoutedEventArgs e)
        {
            WeldChkBox.IsChecked = AssemblyChkBox.IsChecked = PlasmaChkBox.IsChecked = LaserChkBox.IsChecked = PurchaseChkBox.IsChecked = LatheChkBox.IsChecked = DrillChkBox.IsChecked = FoldChkBox.IsChecked = RollChkBox.IsChecked = SawChkBox.IsChecked = false;
        }

        private void ChkBox_OnChecked(object sender, RoutedEventArgs e)
        {
            LengthTxtBox.Text += ((CheckBox) sender).Content + "  ";
        }

        private void FinishComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (NoteTxtBox == null)
                return;
    
            var combo = (ComboBox) sender;
            var value = (ComboBoxItem) combo.SelectedValue;

            NoteTxtBox.Text = (string) value.Content;
        }

        private void PurchaseInfoComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Not implemented yet!
        }

        private void SupplierNameTxtBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            MassTxtBox.Text = SupplierNameTxtBox.Text;
        }
    }
}

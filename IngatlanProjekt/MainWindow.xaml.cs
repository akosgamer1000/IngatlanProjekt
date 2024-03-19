using System.Windows;
using System.Windows.Controls;

namespace IngatlanApp
{
    public partial class MainWindow : Window
    {
        private Ingatlanok ingatlanok;

        public MainWindow()
        {
            InitializeComponent();
            ingatlanok = new Ingatlanok(); 
        }

        private void FeladatokListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FeladatokListBox.SelectedItem is ListBoxItem selectedItem)
            {
                
            }
        }
    }
}

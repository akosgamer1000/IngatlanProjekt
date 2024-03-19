using System.Collections.Generic;
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
               switch(selectedItem.Content.ToString())
                {
                    case "Összes eladás száma":
                        ingatlanok.eladásokszáma();
                        EredmenyekTextBlock.Text = $"{ingatlanok.eladásokszáma()}";


						break;
                    case "Legnagyobb területű ingatlan":


                        EredmenyekTextBlock.Text = ingatlanok.s().ToString();
						
						break;
                    case "Összesített eladások értéke":

                        EredmenyekTextBlock.Text = $"{ingatlanok.össz()}";
                        break;
				} 
            }
        }
    }
}

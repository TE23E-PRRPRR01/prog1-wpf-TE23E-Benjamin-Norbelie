using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BrännbollApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
    {
        
        int poangInne = 0;
        int poangUte = 0;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void KlickFrivarv(object sender, RoutedEventArgs e)
        {
            poangInne += 5;
            tbxLagInne.Text = poangInne.ToString();
            LäggTillHistorik("Lag Inne Frivarv +5 poäng", poangInne, poangUte);
        }

        private void KlickBränning(object sender, RoutedEventArgs e)
        {
            poangUte += 2;
            tbxLagUte.Text = poangUte.ToString();
            LäggTillHistorik("Lag Ute Bränning +2 poäng", poangInne, poangUte);
        }

        private void KlickLyra(object sender, RoutedEventArgs e)
        {
            poangUte += 3;
            tbxLagUte.Text = poangUte.ToString();
            LäggTillHistorik("Lag Ute Lyra +3 poäng", poangInne, poangUte);
        }

        private void KlickVarv(object sender, RoutedEventArgs e)
        {
            poangInne += 1;
            tbxLagInne.Text = poangInne.ToString();
            LäggTillHistorik("Lag Inne Varv +1 poäng", poangInne, poangUte);

        }

        private void LäggTillHistorik(string händelse, int poangInne, int poangUte)
        {
            string historikText = $"{händelse} (Lag Inne: {poangInne} | Lag Ute: {poangUte})";
            txbHistorik.Items.Insert(0, historikText); // Lägger till i ListBox
        }
    }
    
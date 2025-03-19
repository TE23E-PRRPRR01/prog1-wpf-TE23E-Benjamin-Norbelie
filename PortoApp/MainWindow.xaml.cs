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

namespace PortoApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void klickRäknaPorto(object sender, RoutedEventArgs e)
    {
        if (int.TryParse(txbNamn.Text, out int vikt))
        {
            string resultat = räknaPorto(vikt);
            lblResultat.Content = resultat;
        }
        else
        {
           lblResultat.Content = "Inte giltig vikt.";
        }
    }
    private string räknaPorto(int vikt)
    {
        if (vikt <= 50)
            return $"Brev som väger {vikt} g kostar 22 kr (1 frimärke)";
        else if (vikt <= 100)
            return $"Brev som väger {vikt} g kostar 44 kr (2 frimärken)";
        else if (vikt <= 250)
            return $"Brev som väger {vikt} g kostar 66 kr (3 frimärken)";
        else if (vikt <= 500)
            return $"Brev som väger {vikt} g kostar 88 kr (4 frimärken)";
        else if (vikt <= 1000)
            return $"Brev som väger {vikt} g kostar 132 kr (6 frimärken)";
        else if (vikt <= 2000)
            return $"Brev som väger {vikt} g kostar 154 kr (7 frimärken)";
        else
            return "Vikten överskrider maxgränsen för porto.";
    }
}

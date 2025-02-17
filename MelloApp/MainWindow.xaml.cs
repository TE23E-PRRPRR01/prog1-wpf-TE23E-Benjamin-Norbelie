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

namespace MelloApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    // Variabler för att räkna röster
    private int antalrod = 0;
    private int antalbla = 0;
    private int antalgron = 0;
    private int antallila = 0;
    private int antalgul = 0;

    public MainWindow()
    {
        InitializeComponent();
    }

    // Metod som anropas när en röstknapp klickas
    private void KlickRösta(object sender, RoutedEventArgs e)
{
    if (sender == rod) { antalrod++; }
    else if (sender == bla) { antalbla++; }
    else if (sender == gron) { antalgron++; }
    else if (sender == lila) { antallila++; }
    else if (sender == gul) { antalgul++; }

    txbResultat.Text = $"Röd: {antalrod}, Blå: {antalbla}, Grön: {antalgron}, Lila: {antallila}, Gul: {antalgul}";
}
private void KlickRensa(object sender, RoutedEventArgs e)
{

    antalrod = 0;
    antalbla = 0;
    antalgron = 0;
    antallila = 0;
    antalgul = 0;

    // Uppdatera textfältet
    txbResultat.Text = $"Röd: {antalrod}, Blå: {antalbla}, Grön: {antalgron}, Lila: {antallila}, Gul: {antalgul}";
}

}
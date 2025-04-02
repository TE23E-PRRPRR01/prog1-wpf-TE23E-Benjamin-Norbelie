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

namespace GissaApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    //slumpa fram ett tal mellan 1 och 1000
    int slumptal = Random.Shared.Next(1, 1001);
    List<int> listaGissningar = [];

    private void KlickGissa(object sender, RoutedEventArgs e)
    {
        //läs in gissning
        string input = txbGissning.Text;

        //konvert till ett heltal
        bool lyckades = int.TryParse(input, out int gissning);
        //lyckades konverteringen
        if (lyckades)
        {
            listaGissningar.Add(gissning);
            //kontrollera att gissningen är mellan 1 och 1000
            if (gissning < 1 || gissning > 1000)
            {
                txbResultat.Text = "Gissningen måste vara mellan 1 och 1000!";
                return;
            }


            //jämföra gissning med slumptal
            if (gissning == slumptal)
            {
                //om gissning är rätt
                //visa meddelande
                txbResultat.Text = "Rätt!";
            }
            else if (gissning < slumptal)
            {
                //om gissning är för lågt
                //visa meddelande
                txbResultat.Text = "För lågt!";
            }
            else if (gissning > slumptal)
            {
                //om gissning är för högt
                //visa meddelande
                txbResultat.Text = "För högt!";
            }

        }
        else
        {
            txbResultat.Text = "Felaktig inmatning!";

        }





    }

    private void KlickFacit(object sender, RoutedEventArgs e)
    {
        //visa facit
        txbResultat.Text = $"Facit: {slumptal}";
    }

    private void KlickVisaGissningar(object sender, RoutedEventArgs e)
    {
        // skriv ut alla gissningar som finns i listan
foreach (var tal in listaGissningar)
{
        txbGissningar.Text += $"{tal}\n";
    
}


    }
    private void KlickÅterställ(object sender, RoutedEventArgs e)
    {
        slumptal = Random.Shared.Next(1, 1001);
        //ränsagränssnittet
        listaGissningar = [];
        txbGissningar.Text = " ";
        txbResultat.Text = " ";
        txbGissning.Text = " ";
    }
}

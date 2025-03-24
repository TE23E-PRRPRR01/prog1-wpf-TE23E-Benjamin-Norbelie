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

namespace Aritmetiken;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    event EventHandler<EventArgs> ButtonClick;
    private void Button_Click(object sender, RoutedEventArgs e)
    {

    }

    private void räknaUt(object sender, RoutedEventArgs e)
    {
        // Läs av alla rutorna
        string stringTal1 = txbTal1.Text;
        string stringTal2 = txbTal2.Text;
        string op = txbOperator.Text;

        // Försök att konvertera inmatningarna till heltal
        if (!int.TryParse(stringTal1, out int tal1) || !int.TryParse(stringTal2, out int tal2))
        {
            lblSavar.Content = "Fel: Ogiltig inmatning!";
            return;
        }

        int resultat = 0;

        // Utför beräkningen baserat på operatorn
        switch (op)
        {
            case "+":
                resultat = tal1 + tal2;
                break;
            case "-":
                resultat = tal1 - tal2;
                break;
            case "*":
                resultat = tal1 * tal2;
                break;
            case "/":
                if (tal2 != 0)
                {
                    resultat = tal1 / tal2;
                }
                else
                {
                    lblSavar.Content = "Fel: Division med 0!";
                    return;
                }
                break;
            default:
                lblSavar.Content = "Fel: Ogiltig operator!";
                return;
        }

        // Visa resultatet
        lblSavar.Content = $"Resultat: {resultat}";
    }
}
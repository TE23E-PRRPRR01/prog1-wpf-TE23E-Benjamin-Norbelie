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

namespace AreaApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void KlickRäknaUt(object sender, RoutedEventArgs e){
        // Hämta bredd och höjd från textfälten


        //kontrollera om det är text  eller tal i rutorna
        if (!int.TryParse(txbBredd.Text, out int bredd))
        {
            txbArea.Text = "fel inmatatat värde";
            return;
        }
        if (!int.TryParse(txbHojd.Text, out int Hojd))
        {
            txbArea.Text = "fel inmatatat värde";
            return;
        }

        // Beräkna arean
        int area = bredd * Hojd;

        // Visa resultatet i textfältet
        txbArea.Text = area.ToString();
    }
    private void Rensar(object sender, RoutedEventArgs e)
    {
        txbArea.Text = "".ToString();
        txbBredd.Text = "".ToString();
        txbHojd.Text = "".ToString();

    }
}
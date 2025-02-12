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

namespace SlummpaApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void slumpatTal(object sender, RoutedEventArgs e)
    {
        if (int.TryParse(maxVärdetxb.Text, out int maxvärde) && maxvärde > 0)
        {



            //generera slumptal mellan 1 och 100
            int slumptal = Random.Shared.Next(1, maxvärde + 1);

            //visa slumptalet i textboxen resultat
            resultattxb.Text = slumptal.ToString();
        }
        else
        {
            resultattxb.Text = "Fel!";
        }

    }


}
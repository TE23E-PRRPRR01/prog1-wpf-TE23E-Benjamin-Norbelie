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
using System.Net.Http.Json;
using System.Net.Http;

namespace AiApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    //redska för att komminucera över http
    HttpClient klient = new HttpClient();
    //adressen till api
    string url = "http://10.151.168.5:11434/api/generate";
    public MainWindow()
    {
        InitializeComponent();
    }
    private void KlicklSkicka(object sender, RoutedEventArgs e)
    {
        //läsa av prompttexten i rutan
        string prompt = txbPrompt.Text;

        //skapa ett json-objekt
        object data = new
        {
            model = "phi4:latest",
            prompt = prompt,
            max_tokens = 100

        };
        //skicka till ollam-ai servern
        SkickaTillOllama(data);

    }
    public void SkickaTillOllama(object data)
    {
        try
        {

            //skicka data till servern
            HttpResponseMessage svar = klient.PostAsJsonAsync(url, data).Result;

            //kontrollera att "requesten" lyckades
            svar.EnsureSuccessStatusCode();

            //läsa innehållet i svaret
            string råtext = svar.Content.ReadAsStringAsync().Result;

            //dela upp råtexten i rader
            string[] rader = råtext.Split("\n");

            // gå igenom alla rader
            foreach (string rad in rader)
            {
                //finns response
                if (rad.Contains("response"))
                {
                    txbSvar.Text += PlockautToken(rad);

                }
                else
                {

                }
            }
        }
        catch (HttpRequestException e)
        {
            //skriv ut felmeddelande
            txbSvar.Text = $"Fel: {e.Message}";

        }

    }
    public string PlockautToken(string rad)
    {
        int start = rad.IndexOf("response") + 11;
        int slut = rad.IndexOf("\"", start);

        //Plocka ut token
        return rad.Substring(start, slut - start);


    }
}
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace funfactgenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Sinan gerwig");

            Dictionary<string, String> funfact = new Dictionary<string, string>();

            funfact.Add("0815", "Der Begriff 0815 bedeutet, das Etwas normal oder bei allen gleich ist und kommt vom 2ten Weltkrieg, da die deutschen alle in ihrer Standartausrüstung das MG 0815 hatten");
            funfact.Add("winston churchill", "Winston Churchill hatte eine Phase, in der er von der britischen Bevölkerung verabscheut wurde. Er wurde nähmlich für die Niederlage gegen das osmanische Reich im 1 Weltkrieg beschuldigt, so dass man den richtigen Schuldigen nicht entlassen musste ");
            funfact.Add("deutsches reich", "Das Deutsche Reich hatte um 1942 Die grösste Ausmasse punkto Grösse erreicht.Karte: siehe https://youtube.com/shorts/usBJi9K8x0o?si=6UueHY9cqjo8dwXe ");
            funfact.Add("last man standing", "Der Letzte Japaner ergab sich erst 1947. Er dachte die Meldung der Kapitulatin des Japanischen Reichs, sei eine FInte der Amerikaner. Er blieb all die Jahre auf Gefechtstation.");
            funfact.Add("adolf hitler", "Bereits zu seinen Lebzeiten, aber auch weit über seinen Tod hinaus wurde Hitler immer wieder mit klinisch relevanten Störungsbildern wie Hysterie, Psychopathie oder megalomaner und paranoider Schizophrenie in Verbindung gebracht.");
            funfact.Add("fanta", "Da die kriegsbedingte Verknappung der Rohstoffe die Produktion von Coca-Cola in Deutschland erschwerte, entwickelte der deutsche Coca-Cola-Chefchemiker Wolfgang Schetelig 1940 in Essen Fanta als Ersatzprodukt, so dass The Coca-Cola Company nicht auf das Geschäft in Deutschland verzichten musste.");
            funfact.Add("nations", "Mehr als 70 Staaten namen direkt oder indirekt am 2ten Weltkrieg teil");
            funfact.Add("first", "der erste tote war ein pole namens Franciszek Honiok");
            funfact.Add("bomb", "Die erst bombe die über Berlin abgeworfen wurde, tötete keinen einzigen Menschen. Das einzige Opfer war der beliebte Elefant im Berliner Zoo.");
            funfact.Add("okinawa", "Dasmond Doss ist bis jetzt der einzige SOldat der US Armee, der jemals eine Medal of Honor erreichen konnte, ohne auch nur einmal eine Waffe zu berühren. Er war Feldsanitäter und rettete fast 100 Soldaten (japaner und Amerikaner) in der Schlacht um Okinawa");
            funfact.Add("blümelein", "Das Altbekannte Nazilied war einmal ein ganz normales Lied was zb. zum feiern in einer Bar gesungen wurde, Wie es die Nazis aber auch mit den Swastikas gemacht haben <<missbrauchten>> sie das lied als Marschlied.");
            funfact.Add("Schweiz", "Die schweiz hat einen grossen Teil des heutigen Reichtums dem 2ten Weltkrieg zu verdanken. Sie war eine Bankennation, welche von allen kriegsteilnehmenden Regierungen Gold, geld und von Deutschland vorallem DIebesgut aufgenommen hat. Nach dem Krieg waren viel der Nazis tot oder geflohen und die Schweiz behielt dann sozusagen alles");

            Console.WriteLine("Willst du alle verfügbaren Stichwörter hören?");
            string alle = Console.ReadLine();
            if (alle == "nein")
            {
                Console.WriteLine("okay");
            }

            else if (alle =="ja")
                foreach (KeyValuePair<string, string> kvp in funfact)
                {
                    Console.WriteLine("Stichwort: " + kvp.Key);
                    Console.WriteLine();
                }



            string janein = "ja";
            while (janein == "ja")
            {
                

               

                Console.WriteLine("Sinan, sag mir ein geschichtliches Stichwort");
                string stichwort = Console.ReadLine().ToLower();

                if (funfact.ContainsKey(stichwort))
                {
                    Console.WriteLine("Fun Fact für '" + stichwort + "': " + funfact[stichwort]);
                }
                else
                {
                    Console.WriteLine("Es gibt keinen Fun Fact für '" + stichwort + "'.");
                }

                Console.WriteLine("Willst du einen weiteren Fun Fact hören?");
                Console.Write("Bitte gib 'ja' oder 'nein' ein: ");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "ja")
                {
                    janein = "ja";
                }
                else if (userInput.ToLower() == "nein")
                {
                    janein = "nein";
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Erwartet wurden 'ja' oder 'nein'.");

                }










            }

        
        }


    }
}